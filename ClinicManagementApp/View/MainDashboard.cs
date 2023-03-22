using ClinicManagementApp.Controller;
using System.Windows.Forms;

namespace ClinicManagementApp
{
    public partial class MainDashboard : Form
    {
        private readonly NurseController _nurseController;

        public MainDashboard(string username)
        {
            InitializeComponent();
            this._nurseController = new NurseController();
            this.welcomeUserLabel.Text = "Welcome " + this._nurseController.GetNurseName(username) + " (username: " + username + ")!";
        }

        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
