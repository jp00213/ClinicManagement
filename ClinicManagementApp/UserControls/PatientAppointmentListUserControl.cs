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
        /// <summary>
        /// create constructors
        /// </summary>
        public PatientAppointmentListUserControl()
        {
            InitializeComponent();
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
