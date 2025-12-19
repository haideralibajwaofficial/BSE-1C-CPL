using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;

namespace BU_Kit
{
    public partial class adminDashboard : Form
    {
        Form Parent;
        public adminDashboard(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Parent.Show();
            this.Hide();
        }

        

        public static class AdminEmailPoller
        {
            // Add this to appConfig.cs - list of all client emails to monitor
            private static string[] clientEmails = new string[]
            {
            "haideralibajwaofficial@gmail.com",
                "haiderali8f3258@gmail.com"
                // Add all your client emails here
            };

            public static void StartAdminEmailPolling(string adminEmail, string adminPassword)
            {
                Console.WriteLine($"[ADMIN] Starting email monitor for: {adminEmail}");
                Console.WriteLine($"[ADMIN] Monitoring {clientEmails.Length} clients");

                while (true)
                {
                    try
                    {
                        using (var client = new ImapClient())
                        {
                            client.Connect("imap.gmail.com", 993, true);
                            client.Authenticate(adminEmail, adminPassword);
                            //Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Admin logged in, checking for new emails...");

                            var inbox = client.Inbox;
                            inbox.Open(FolderAccess.ReadOnly);

                            // Read last processed UID for admin
                            string adminLastUidPath = Path.Combine(appConfig.mainDir, "admin_lastUid.txt");
                            uint lastUid = 0;
                            if (File.Exists(adminLastUidPath))
                            {
                                string lastUidText = File.ReadAllText(adminLastUidPath).Trim();
                                if (!string.IsNullOrEmpty(lastUidText))
                                {
                                    lastUid = uint.Parse(lastUidText);
                                }
                            }

                            // Search for emails from ANY of the client emails
                            var allUids = new List<UniqueId>();
                            foreach (string clientEmail in clientEmails)
                            {
                                var uids = inbox.Search(SearchQuery.FromContains(clientEmail));
                                allUids.AddRange(uids);
                            }

                            // Remove duplicates and sort
                            var sortedUids = allUids.Distinct().OrderBy(u => u.Id).ToList();
                            Console.WriteLine($"Found {sortedUids.Count} total emails from clients");

                            bool foundNew = false;
                            uint highestUid = lastUid;

                            foreach (var uid in sortedUids)
                            {
                                if (uid.Id <= lastUid)
                                    continue;

                                Console.WriteLine($"Processing new email with UID: {uid.Id}");
                                foundNew = true;

                                var message = inbox.GetMessage(uid);
                                string senderEmail = message.From.Mailboxes.First().Address;

                                Console.WriteLine($"  From: {senderEmail}");

                                bool attachmentFound = false;
                                string downloadedFilePath = null;

                                // Download attachments
                                foreach (var attachment in message.Attachments)
                                {
                                    if (attachment is MimePart part && part.FileName != null)
                                    {
                                        if (part.FileName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase) ||
                                            part.ContentType.MimeType == "text/plain")
                                        {
                                            // Save to main db path
                                            downloadedFilePath = Path.Combine(appConfig.mainDir, part.FileName);
                                            using (var stream = File.Create(downloadedFilePath))
                                            {
                                                part.Content.DecodeTo(stream);
                                            }

                                            Console.WriteLine($"✓ Downloaded: {part.FileName}");
                                            attachmentFound = true;

                                            // Reload data
                                            appConfig.data = File.ReadAllLines(downloadedFilePath);

                                            // Forward to all OTHER clients (not the sender)
                                            ForwardToClients(adminEmail, adminPassword, senderEmail, downloadedFilePath, part.FileName);

                                            break;
                                        }
                                    }
                                }

                                if (!attachmentFound)
                                {
                                    Console.WriteLine($"  No .txt attachment found in UID {uid.Id}");
                                }

                                if (uid.Id > highestUid)
                                {
                                    highestUid = uid.Id;
                                }
                            }

                            // Update admin's lastUid
                            if (highestUid > lastUid)
                            {
                                File.WriteAllText(adminLastUidPath, highestUid.ToString());
                                Console.WriteLine($"Updated admin last UID to: {highestUid}");
                            }

                            if (!foundNew)
                            {
                                Console.WriteLine("No new emails from clients.");
                            }

                            client.Disconnect(true);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"[ADMIN ERROR]: {ex.Message}");
                        File.AppendAllText(appConfig.errorLogPath,
                            $"[ADMIN {DateTime.Now}] {ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
                    }

                    Console.WriteLine("Waiting 30 seconds before next check...\n");
                    Thread.Sleep(30000);
                }
            }

            private static void ForwardToClients(string adminEmail, string adminPassword, string originalSender, string filePath, string fileName)
            {
                try
                {
                    using (var smtpClient = new SmtpClient())
                    {
                        smtpClient.Connect("smtp.gmail.com", 587, false);
                        smtpClient.Authenticate(adminEmail, adminPassword);

                        // Get list of recipients (all clients EXCEPT the original sender)
                        var recipients = clientEmails.Where(email => email != originalSender).ToList();

                        Console.WriteLine($"  Forwarding to {recipients.Count} clients...");

                        foreach (string recipientEmail in recipients)
                        {
                            var message = new MimeMessage();
                            message.From.Add(new MailboxAddress("Admin", adminEmail));
                            message.To.Add(new MailboxAddress("", recipientEmail));
                            message.Subject = "Updated Database";

                            var bodyBuilder = new BodyBuilder();
                            bodyBuilder.TextBody = $"Database updated by {originalSender}. Please find the latest version attached.";
                            bodyBuilder.Attachments.Add(filePath);

                            message.Body = bodyBuilder.ToMessageBody();

                            smtpClient.Send(message);
                            Console.WriteLine($"    ✓ Sent to {recipientEmail}");
                        }

                        smtpClient.Disconnect(true);
                        Console.WriteLine($"  Successfully forwarded {fileName} to all clients!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  ✗ Forward failed: {ex.Message}");
                    File.AppendAllText(appConfig.errorLogPath,
                        $"[FORWARD ERROR {DateTime.Now}] {ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
                }
            }
        }
    }
}
