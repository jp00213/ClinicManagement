using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementApp.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (this.usernameTextBox.Text == "jane" && this.passwordTextBox.Text == "test1234")
            {
                this.Hide();
                using (Form mainWindow = new MainDashboard())
                {
                    DialogResult result = mainWindow.ShowDialog(this);
                }
            }
            else { this.errorMessageLabel.Text = "invalid username/password"; }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
