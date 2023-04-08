using ClinicManagementApp.Controller;
using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    /// <summary>
    /// Labs User Control
    /// </summary>
    public partial class LabsUserControl : UserControl
    {
        private readonly PatientController _patientController;
        /// <summary>
        /// Constructor for labs user control
        /// </summary>
        public LabsUserControl()
        {
            InitializeComponent();
            _patientController = new PatientController();
        }

        private void AppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            List<Patient> patients = this._patientController.GetPatientsByVisitDate(this.appointmentDateTimePicker.Value);

            if(patients.Count > 0)
            {
                this.patientComboBox.DataSource = patients;
                this.patientComboBox.DisplayMember = "FullName";
                this.patientComboBox.ValueMember = "PatientID";
            }
            else
            {
                MessageBox.Show("No patients with a visit on " + this.appointmentDateTimePicker.Value.ToString("dd/MM/yyyy"));
            }
        }
    }
}
