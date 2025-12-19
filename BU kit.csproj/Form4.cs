using System;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MimeKit;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace BU_Kit
{
    public partial class teacherDashboard : Form
    {
        static bool clicked = false;
        static bool clickedEntry  = false;
        static bool clickedFind = false;
        static string campus, room, shelf, column;
        string[] allFiles = null;
        void visible()
        {
            findFileBtn.Visible = clicked;
            newEntryBtn.Visible = clicked;
             
        }

        void visibleEntry()
        {
            campusSelect.Visible = clickedEntry;
            roomComboBox.Visible = clickedEntry;
            shelfComboBox.Visible = clickedEntry;
            columnComboBox.Visible = clickedEntry;
            submitBtn.Visible = clickedEntry;
            enrollmentTxt.Visible = clickedEntry;
            enrollmentTxt2.Visible = clickedEntry;
            enrollmentLbl.Visible = clickedEntry;
            campusLbl.Visible = clickedEntry;
            roomLbl.Visible = clickedEntry;
            shelfLbl.Visible = clickedEntry;
            columnLbl.Visible = clickedEntry;
        }

        void visibleFind()
        {
            enrollmentFindTxt.Visible = clickedFind;
            findBtn.Visible = clickedFind;
            enrollmentFindLbl.Visible = clickedFind;
        }



        string fileDb = Path.Combine(appConfig.mainDir, "files.txt"); 
        Form Parent;
        public teacherDashboard(Form parent)
        {
            InitializeComponent();
            Parent = parent;
            signedInTxt.Text = menu.get(menu.enroll, "firstname") + " " + menu.get(menu.enroll, "lastname");
            if(!File.Exists(fileDb))
            {
                File.WriteAllText(fileDb, "");
            }
            allFiles = File.ReadAllLines(fileDb);
            visible ();
            visibleEntry();
            visibleFind();

        }

        private void roomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            room = roomComboBox.SelectedItem.ToString(); 
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {

        }

        private void shelfComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shelf = shelfComboBox.SelectedItem.ToString();
        }

        private void columnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            column = columnComboBox.SelectedItem.ToString();
        }

        private void newEntryBtn_Click(object sender, EventArgs e)
        {
            clickedEntry = !clickedEntry;
            visibleEntry();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void enrollmentTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(room) || string.IsNullOrEmpty(shelf) || string.IsNullOrEmpty(column) || string.IsNullOrEmpty(campus) || string.IsNullOrEmpty(enrollmentTxt.Text) || string.IsNullOrEmpty(enrollmentTxt2.Text))
            {
                MessageBox.Show("Invalid Info");
                return;
            }

            if (enrollmentTxt.Text != enrollmentTxt2.Text)
            {
                MessageBox.Show("Enrollments doesnt match");
                return;
            }
            foreach (string file in allFiles)
            {
                if (file.Contains(enrollmentTxt.Text))
                {
                    MessageBox.Show("File Already Exists!");
                    return;
                }

                if (file.EndsWith($"{campus}, {room}, {shelf}, {column}\n"))
                {
                    MessageBox.Show("Space Already Occupied!");
                    return;
                }
            }


            File.AppendAllText(fileDb, $"{enrollmentTxt.Text}, {campus}, {room}, {shelf}, {column}\n");
            MessageBox.Show($"A new entry with enrollment {enrollmentTxt.Text} is made successfully");
            allFiles = File.ReadAllLines(fileDb);

            // --- SMTP: Send a simple email ---
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.gmail.com", 587, false);
                smtpClient.Authenticate(menu.get(menu.enroll, "email"), menu.get(menu.enroll, "password"));

                var messageToSend = new MimeMessage();
                messageToSend.From.Add(new MailboxAddress(menu.get(menu.enroll, "firstname"), menu.get(menu.enroll, "email")));
                messageToSend.To.Add(new MailboxAddress("Admin", appConfig.sender));
                messageToSend.Subject = "Test Email";
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = "Hello! This is a test email with attachment.";

                // Attach the db.txt file
                bodyBuilder.Attachments.Add(fileDb);

                messageToSend.Body = bodyBuilder.ToMessageBody();

                smtpClient.Send(messageToSend);
                smtpClient.Disconnect(true);
                enrollmentTxt.Text = enrollmentTxt2.Text = null;
            }
        }

        private void findFileBtn_Click(object sender, EventArgs e)
        {
            clickedFind = !clickedFind;
            visibleFind();
            
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(enrollmentFindTxt.Text))
            {
                return;
            }

            
            string enroll = enrollmentFindTxt.Text;

            foreach (string file in allFiles) {
                if (file.Contains(enroll))
                {
                    string[] fields = file.Split(',');
                    MessageBox.Show($"File: {enroll}\n Campus: {fields[1]}\n Room: {fields[2]}\n Shelf: {fields[3]}\n Column: {fields[4]}");
                }
            }
            MessageBox.Show($"No file found with enrollment: {enroll}");
        }

        private void teacherDashboard_Load(object sender, EventArgs e)
        {
            campusSelect.Items.Add("Karachi Campus");
            campusSelect.Items.Add("Islamabad Campus");
            for (int i = 0; i < appConfig.campusRooms.GetLength(1); i++)
            {
                if (appConfig.campusRooms[0, i] == null)
                    continue;

                roomComboBox.Items.Add(appConfig.campusRooms[0, i]);
            }

            for (int i = 1; i <= 8; i++)
            {
                shelfComboBox.Items.Add(i.ToString  ());    
            }

            for (int i = 1; i <= 4; i++)
            {
                columnComboBox.Items.Add(i.ToString());
            }
        }

        private void inventoryMngBtn_Click(object sender, EventArgs e)
        {
            clicked = !clicked;
            visible();
            if(clicked == false)
            {
                clickedEntry = false;
                visibleEntry();
                clickedFind = false;
                visibleFind();
            }
        }

        private void campusSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            campus = campusSelect.SelectedItem.ToString();
            if (campus == "Karachi Campus")
            {
                roomComboBox.Items.Clear();
                room = null;
                for (int i = 0; i < appConfig.campusRooms.GetLength(1); i++)
                {
                    if (appConfig.campusRooms[0, i] == null)
                        continue;

                    roomComboBox.Items.Add(appConfig.campusRooms[0, i]);
                }
            }
            else
            {
                roomComboBox.Items.Clear();
                for (int i = 0; i < appConfig.campusRooms.GetLength(1); i++)
                {
                    if (appConfig.campusRooms[1, i] == null)
                        continue;

                    roomComboBox.Items.Add(appConfig.campusRooms[1, i]);
                }
            }

        }
    }
}
