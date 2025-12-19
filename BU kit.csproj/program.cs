using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BU_Kit
{
    internal static class Program
    {
        public static Thread emailThread = null;

        public static void StartEmailPolling(string email, string password)
        {
            while (true)
            {
                try
                {
                    using (var client = new ImapClient())
                    {
                        client.Connect("imap.gmail.com", 993, true);
                        client.Authenticate(email, password);

                        var inbox = client.Inbox;
                        inbox.Open(FolderAccess.ReadOnly);

                        uint lastUid = 0;
                        if (File.Exists(appConfig.lastUidPath))
                        {
                            string lastUidText = File.ReadAllText(appConfig.lastUidPath).Trim();
                            if (!string.IsNullOrEmpty(lastUidText))
                            {
                                lastUid = uint.Parse(lastUidText);
                            }
                        }

                        var uids = inbox.Search(SearchQuery.FromContains(appConfig.sender));
                        var sortedUids = uids.OrderBy(u => u.Id).ToList();

                        bool foundNew = false;
                        uint highestUid = lastUid;

                        foreach (var uid in sortedUids)
                        {
                            if (uid.Id <= lastUid)
                                continue;

                            foundNew = true;
                            var message = inbox.GetMessage(uid);
                            bool attachmentFound = false;

                            foreach (var attachment in message.Attachments)
                            {
                                if (attachment is MimePart part && part.FileName != null)
                                {
                                    if (part.FileName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase) ||
                                        part.ContentType.MimeType == "text/plain")
                                    {
                                        string dbPath = Path.Combine(appConfig.mainDir, part.FileName);
                                        using (var stream = File.Create(dbPath))
                                        {
                                            part.Content.DecodeTo(stream);
                                        }

                                        attachmentFound = true;
                                        appConfig.data = File.ReadAllLines(dbPath);
                                        break;
                                    }
                                }
                            }

                            if (uid.Id > highestUid)
                            {
                                highestUid = uid.Id;
                            }
                        }

                        if (highestUid > lastUid)
                        {
                            File.WriteAllText(appConfig.lastUidPath, highestUid.ToString());
                        }

                        client.Disconnect(true);
                    }
                }
                catch (Exception ex)
                {
                    File.AppendAllText(appConfig.errorLogPath,
                        $"[{DateTime.Now}] {ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
                }

                Thread.Sleep(30000);
            }
        }

        [STAThread]
        static void Main()
        {
            Directory.CreateDirectory(appConfig.mainDir);

            if (!File.Exists(appConfig.dbPath))
            {
                File.WriteAllText(appConfig.dbPath, "");
            }

            appConfig.data = File.ReadAllLines(appConfig.dbPath);

            // DON'T start email thread here - wait until after login

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new menu());
        }
    }
}
