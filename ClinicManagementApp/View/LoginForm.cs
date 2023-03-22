using ClinicManagementApp.Controller;
using System;
using System.Windows.Forms;

namespace ClinicManagementApp.View
{
    public partial class LoginForm : Form
    {
        private readonly AccountController _accountController;

        public LoginForm()
        {
            InitializeComponent();
            this._accountController = new AccountController();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._accountController.IsUsernamePasswordCorrectForNurse(this.usernameTextBox.Text, this.passwordTextBox.Text))
                {
                    this.Hide();
                    using (Form mainWindow = new MainDashboard(this.usernameTextBox.Text))
                    {
                        DialogResult result = mainWindow.ShowDialog(this);
                    }
                }
                else { this.errorMessageLabel.Text = "Invalid username/password"; }
            }
            catch (ArgumentOutOfRangeException)
            {
                this.errorMessageLabel.Text = "Username/password can't be blank";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
