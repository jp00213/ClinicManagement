using ClinicManagementApp.Controller;
using ClinicManagementApp.DAL;
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
            this.patientComboBox.DataSource = this._patientController.GetPatientsByVisitDate(this.appointmentDateTimePicker.Value);
        }
    }
}
