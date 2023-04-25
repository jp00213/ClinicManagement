using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Windows.Forms;

namespace ClinicManagementApp.View
{
    /// <summary>
    /// Main Dashboard for Administrators
    /// </summary>
    public partial class AdministratorDashboard : Form
    {
        private readonly AdministratorController _administratorController;

        /// <summary>
        /// Constructor for the Main Dashboard for Administrators
        /// </summary>
        /// <param name="username"></param>
        public AdministratorDashboard(string username)
        {
            InitializeComponent();
            this._administratorController = new AdministratorController();
            try
            {
                Person currentAdministrator = this._administratorController.GetAdminstratorByUsername(username);
                string fullName = currentAdministrator.FirstName + " " + currentAdministrator.LastName;
                this.welcomeUserLabel.Text = "Welcome " + fullName + " (username: " + username + ")!";
            }
            catch (Exception ex)
            {
                this.welcomeUserLabel.Text = "Welcome unknown user!";
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void AdministratorDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
