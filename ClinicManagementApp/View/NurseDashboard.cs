using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Windows.Forms;

namespace ClinicManagementApp
{
    /// <summary>
    /// Main Dashboard for Nurses
    /// </summary>
    public partial class NurseDashboard : Form
    {
        private readonly NurseController _nurseController;

        /// <summary>
        /// Constructor for the Main Dashboard for Nurses
        /// </summary>
        /// <param name="username"></param>
        public NurseDashboard(string username)
        {
            InitializeComponent();
            this._nurseController = new NurseController();
            try
            {
                Nurse currentNurse = this._nurseController.GetNurseByUsername(username);
                string fullName = currentNurse.FirstName + " " + currentNurse.LastName;
                this.welcomeUserLabel.Text = "Welcome " + fullName + " (username: " + username + ")!";
                NurseController.SetUsername(username);
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

        private void NurseDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void searchPatientUserControl1_PatientNumberChanged(object sender, EventArgs e)
        {
            this.currentPatientIDLabel.Text = searchPatientUserControl1.getCurrentpatientID();
        }

        /// <summary>
        /// getter current patientID selected from patientDisplayInfoUserControl
        /// </summary>
        public string ID
        {
            get { return this.currentPatientIDLabel.Text; }
        }

        private void currentPatientIDLabel_TextChanged(object sender, EventArgs e)
        {
            this.patientDisplayInfoUserControl1.ID = ID;
            this.patientVisitListUserControl1.ID = ID;
            this.patientAppointmentListUserControl1.ID = ID;
        }

        private void patientInfoButton_Click(object sender, EventArgs e)
        {
            patientDisplayInfoUserControl1.Show();
            patientAppointmentListUserControl1.Hide();
            patientVisitListUserControl1.Hide();
        }

        private void patientAppointmentButton_Click(object sender, EventArgs e)
        {
            patientDisplayInfoUserControl1.Hide();
            patientAppointmentListUserControl1.Show();
            patientVisitListUserControl1.Hide();
        }

        private void patientVisitButton_Click(object sender, EventArgs e)
        {
            patientDisplayInfoUserControl1.Hide();
            patientAppointmentListUserControl1.Hide();
            patientVisitListUserControl1.Show();

        }

    }
}
