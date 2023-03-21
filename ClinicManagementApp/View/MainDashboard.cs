using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementApp
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }


        /// <summary>
        /// getter current patientID selected from patientDisplayInfoUserControl
        /// </summary>
        public string ID
        {
            get { return this.currentPatientIDLabel.Text; }
        }


        private void currentPatientIDLabel_TextChanged_1(object sender, EventArgs e)
        {
            this.patientDisplayInfoUserControl1.ID = ID;
            this.patientVisitListUserControl1.ID = ID;
            this.patientAppointmentListUserControl1.ID = ID;
        }

        private void searchPatientUserControl1_PatientNumberChanged(object sender, EventArgs e)
        {
            this.currentPatientIDLabel.Text = searchPatientUserControl1.getCurrentpatientID();
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
