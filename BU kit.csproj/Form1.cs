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

namespace BU_Kit
{
    public partial class menu : Form
    {
        private void StartEmailPollingThread()
        {
            // Only start if not already running
            if (Program.emailThread == null || !Program.emailThread.IsAlive)
            {
                appConfig.setuid();
                // Now menu.enroll is set, so this will work
                string email = get(enroll, "email");
                string password = get(enroll, "password");

                // Set the lastUidPath now that we know the user
                appConfig.lastUidPath = Path.Combine(appConfig.mainDir, get(enroll, "firstname") + "_lastUid.txt");

                Program.emailThread = new Thread(() => Program.StartEmailPolling(email, password));
                Program.emailThread.IsBackground = true;
                Program.emailThread.Start();
            }
        }
        public static string enroll;

        public menu()
        {
            InitializeComponent();

        }

        public static string get(string id, string type)
        {
            string[] info = new string[12];
            string reqInfo = null;
            int typeInDigit;
            int subtractor = 0;
            

            switch (type.ToLower())
            {
                case "uid":
                    typeInDigit = 0;
                    break;

                case "enrollment":
                    typeInDigit = 1;
                    break;

                case "category":
                    typeInDigit = 2;
                    break;

                case "firstname":
                    typeInDigit = 3;
                    break;

                case "lastname":
                    typeInDigit = 4;
                    break;

                case "dob":
                    typeInDigit = 5;
                    break;

                case "degree":
                    typeInDigit = 6;
                    break;

                case "department":
                    typeInDigit = 7;
                    break;

                case "semester":
                    typeInDigit = 8;
                    break;

                case "email":
                    typeInDigit = 9;
                    break;

                case "password":
                    typeInDigit = 10;
                    break;

                default:
                    typeInDigit = -1;
                    break;
            }


            if (id.StartsWith("02"))
            {
                subtractor = 1;
            }
            else if (id.Contains("@"))
            {
                subtractor = 9;
            }
            else
            {
                subtractor = 3;
            }

            string line;
            for (int i = 0; i < appConfig.data.Length; i++)
            {
                line = appConfig.data[i];
                if (line == id)
                {
                    i -= subtractor;
                    for (int j = 0; j <= 10; j++)
                    {
                        info[j] = appConfig.data[i];
                        i++;
                    }
                    break;
                }
            }


            reqInfo = info[typeInDigit];
            return reqInfo;
        }

        public bool checkString(string category)
        {
            if (string.IsNullOrEmpty(enrollmentTxt.Text))
            {
                return false;
            }
            if (!appConfig.data.Contains(enrollmentTxt.Text) || get(enrollmentTxt.Text, "category") != category)
            {
                MessageBox.Show($"No {category} found with enrollment number: {enrollmentTxt.Text}");
                enrollmentTxt.Text = null;
                return false;
            }
            else
            {
                enroll = enrollmentTxt.Text;
                return true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            if (!checkString("student"))
            {
                return;
            }

            MessageBox.Show("Logged In");

            StartEmailPollingThread();


            studentDashboard stdDashboard = new studentDashboard(this);
            stdDashboard.Show();
            this.Hide();

        }

        private void teacherBtn_Click(object sender, EventArgs e)
        {
            if (!checkString("teacher"))
            {
                return;
            }

            MessageBox.Show("Logged In");
            StartEmailPollingThread();

            teacherDashboard tchrDashboard = new teacherDashboard(this);
            tchrDashboard.Show();
            this.Hide();
        }


        private void adminBtn_Click(object sender, EventArgs e)
        {
            if (!checkString("admin"))
            {
                return;
            }
            else
            {
                adminVerification popUp = new adminVerification(this);
                popUp.Show();

                this.Hide();

                StartEmailPollingThread();

            }
        }
    }

    }


        

/*using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace start
{
    internal class Program
    {
        static string mainDir = @"C:\Users\Malaika\Desktop\BU Kit\test";
        static string dbPath = Path.Combine(mainDir, "db.txt");
        static string newEntry = "x==.==.==.==.==.==.==x";
        static string[] data = null;
        static string sender = "haiderali22006@gmail.com";

        static string errorLogPath = "error.log";
        static string lastUidPath = "lastUID.txt";

        public static string get(string id, string type)
        {
            string[] info = new string[12];
            string reqInfo = null;
            int typeInDigit;
            int subtractor = 0;

            switch (type.ToLower())
            {
                case "uid":
                    typeInDigit = 0;
                    break;

                case "enrollment":
                    typeInDigit = 1;
                    break;

                case "category":
                    typeInDigit = 2;
                    break;

                case "firstname":
                    typeInDigit = 3;
                    break;

                case "lastname":
                    typeInDigit = 4;
                    break;

                case "dob":
                    typeInDigit = 5;
                    break;

                case "degree":
                    typeInDigit = 6;
                    break;

                case "department":
                    typeInDigit = 7;
                    break;

                case "semester":
                    typeInDigit = 8;
                    break;

                case "email":
                    typeInDigit = 9;
                    break;

                case "password":
                    typeInDigit = 10;
                    break;

                default:
                    typeInDigit = -1;
                    break;
            }


            if (id.StartsWith("02"))
            {
                subtractor = 1;
            }
            else if(id.Contains("@"))
            {
                subtractor = 9;
            }
            else
            {
                subtractor = 3;
            }

            string line;
            for(int i = 0; i < data.Length; i++) 
            {
                line = data[i];
                if (line == id)
                {
                    i -= subtractor;
                    for(int j = 0; j <= 10; j++)
                    {
                        info[j] = data[i];
                        i++;
                    }
                    break;
                }
            }
            

            reqInfo = info[typeInDigit];
            return reqInfo;
        }

        static void Main(string[] args)
        {
            Directory.CreateDirectory(mainDir);

            if (!File.Exists(dbPath))
            {
                File.WriteAllText(dbPath, "");
            }

            data = File.ReadAllLines(dbPath);

            int j = 0;
            string enroll = null;
            while (j != 1)
            {
                Console.WriteLine("Enter Enrollment Number:");
                enroll = Console.ReadLine();
                if(!data.Contains(enroll))
                {
                    Console.WriteLine("Invalid Enrollment!");
                }
                else
                {
                    j = 1;
                }
                
            }
            string email = get(enroll, "email");
            string password = get(enroll, "password");


            Console.WriteLine($"Starting email monitor for: {email}");
            Console.WriteLine($"Watching for emails from: {sender}");

            // --- IMAP: Read emails and download .txt attachments ---
            // --- IMAP: Read emails and download .txt attachments ---
            
            while (true) // polling loop
            {
                try
                {
                    using (var client = new ImapClient())
                    {
                        client.Connect("imap.gmail.com", 993, true);
                        client.Authenticate(email, password);
                        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Logged in, checking for new emails...");

                        var inbox = client.Inbox;
                        inbox.Open(FolderAccess.ReadOnly);

                        // Read last processed UID
                        uint lastUid = 0;
                        if (File.Exists(lastUidPath))
                        {
                            string lastUidText = File.ReadAllText(lastUidPath).Trim();
                            if (!string.IsNullOrEmpty(lastUidText))
                            {
                                lastUid = uint.Parse(lastUidText);
                            }
                        }

                        Console.WriteLine($"Last processed UID: {lastUid}");

                        // Search messages from sender
                        var uids = inbox.Search(SearchQuery.FromContains(sender));

                        // Sort UIDs to process in order
                        var sortedUids = uids.OrderBy(u => u.Id).ToList();

                        Console.WriteLine($"Found {sortedUids.Count} total emails from {sender}");

                        bool foundNew = false;
                        uint highestUid = lastUid;

                        foreach (var uid in sortedUids)
                        {
                            // Skip already processed emails
                            if (uid.Id <= lastUid)
                            {
                                continue;
                            }

                            Console.WriteLine($"Processing new email with UID: {uid.Id}");
                            foundNew = true;

                            var message = inbox.GetMessage(uid);

                            bool attachmentFound = false;

                            // Debug: Show what attachments exist
                            Console.WriteLine($"  Checking {message.Attachments.Count()} attachments...");

                            foreach (var attachment in message.Attachments)
                            {
                                var part = attachment as MimePart;
                                if (part != null)
                                {
                                    Console.WriteLine($"    Found: {part.FileName ?? "unnamed"} (ContentType: {part.ContentType.MimeType})");
                                }
                            }

                            // Try to find .txt attachments
                            foreach (var attachment in message.Attachments)
                            {
                                if (attachment is MimePart part && part.FileName != null)
                                {
                                    if (part.FileName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase) ||
                                        part.ContentType.MimeType == "text/plain")
                                    {
                                        using (var stream = File.Create(dbPath))
                                        {
                                            part.Content.DecodeTo(stream);
                                        }

                                        Console.WriteLine($"✓ Downloaded: {part.FileName} to {dbPath}");
                                        attachmentFound = true;

                                        // Reload data after updating db.txt
                                        data = File.ReadAllLines(dbPath);
                                        break; // Only download first matching attachment
                                    }
                                }
                            }

                            if (!attachmentFound)
                            {
                                Console.WriteLine($"No .txt attachment found in UID {uid.Id}");
                            }

                            // Track the highest UID we've seen
                            if (uid.Id > highestUid)
                            {
                                highestUid = uid.Id;
                            }
                        }

                        // Update lastUid.txt with the highest UID processed
                        if (highestUid > lastUid)
                        {
                            File.WriteAllText(lastUidPath, highestUid.ToString());
                            Console.WriteLine($"Updated last processed UID to: {highestUid}");
                        }

                        if (!foundNew)
                        {
                            Console.WriteLine("No new emails.");
                        }

                        client.Disconnect(true);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                    File.AppendAllText(errorLogPath,
                        $"[{DateTime.Now}] {ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
                }

                // Wait before checking again
                Console.WriteLine($"Waiting 30 seconds before next check...{Environment.NewLine}");
                Thread.Sleep(30000); // 30 seconds
            }

            
            // --- SMTP: Send a simple email ---
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.gmail.com", 587, false);
                smtpClient.Authenticate(email, password);

                var messageToSend = new MimeMessage();
                messageToSend.From.Add(new MailboxAddress(get(enroll, "firstname"), email));
                messageToSend.To.Add(new MailboxAddress("Admin", sender));
                messageToSend.Subject = "Test Email";
                messageToSend.Body = new TextPart("plain") { Text = "Hello! This is a test email." };

                smtpClient.Send(messageToSend);
                smtpClient.Disconnect(true);

                Console.WriteLine("Test email sent successfully!");
            }
        }
    }

}

*/