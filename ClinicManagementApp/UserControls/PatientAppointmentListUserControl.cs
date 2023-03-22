using ClinicManagementApp.Controller;
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
    /// this class manages usercontrol for viewing patient appointment schedules
    /// </summary>
    public partial class PatientAppointmentListUserControl : UserControl
    {
        private AppointmentController appointmentController;

        /// <summary>
        /// create constructors
        /// </summary>
        public PatientAppointmentListUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            appointmentDateTimePicker.CustomFormat = "yyyy / MM /dd";
            this.setTimeComboBox();
            this.showFutureRadioButton.Checked = true;
        }

        private void setTimeComboBox()
        {
            var item = DateTime.Today.AddHours(8); // 8:00am
            while (item <= DateTime.Today.AddHours(20)) // 10:00pm
            {
                // timeComboBox.Items.Add( item.TimeOfDay.ToString(@"hh\:mm") );
                newAppointmentComboBox.Items.Add(item.TimeOfDay.ToString(@"hh\:mm"));
                item = item.AddMinutes(15);
            } 
        }
        /// <summary>
        /// setter patientID
        /// </summary>
        public string ID
        {
            set { patientIDTextBox.Text = value; }
        }

        
    }
}
