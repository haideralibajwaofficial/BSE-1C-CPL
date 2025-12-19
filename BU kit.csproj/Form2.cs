using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BU_Kit
{
    public partial class adminVerification : Form
    {
        Form Parent;
        public adminVerification(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void adminVerification_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = passwordTxt.Text;

            if (!(pass == menu.get(menu.enroll, "password")) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Invalid Password");
                return;
            }
            else
            {
                MessageBox.Show("Logged In");

                adminDashboard admDashboard = new adminDashboard(Parent);
                admDashboard.Show();
                this.Hide();
            }
        }


    }
}
