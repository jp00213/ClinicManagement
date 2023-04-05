using ClinicManagementApp.Controller;
using System;
using System.Windows.Forms;

namespace ClinicManagementApp.View
{
    /// <summary>
    /// Login Form for application
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly AccountController _accountController;

        /// <summary>
        /// Constructor for the Login Form
        /// </summary>
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
                    using (Form mainWindow = new NurseDashboard(this.usernameTextBox.Text))
                    {
                        DialogResult result = mainWindow.ShowDialog(this);
                    }
                }
                else if (this._accountController.IsUsernamePasswordCorrectForAdministrator(this.usernameTextBox.Text, this.passwordTextBox.Text)) {
                    this.Hide();
                    using (Form mainWindow = new AdministratorDashboard(this.usernameTextBox.Text))
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
