
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
    /// this class manages usercontrol for viewing patient information
    /// </summary>
    public partial class SearchPatientUserControl : UserControl
    {
        private PatientController _patientController;

        // 1. event - set variable to hold patient id
        private Patient _controlNumber;

        // 2. event - create customer event
        public event EventHandler PatientNumberChanged;

        /// <summary>
        /// create constructors
        /// </summary>
        public SearchPatientUserControl()
        {
            InitializeComponent();
            this._patientController = new PatientController();
            this.SetDefaultPageSetting();
            this._controlNumber = new Patient();

        }

        private void SetDefaultPageSetting()
        {

        }
    }
}
