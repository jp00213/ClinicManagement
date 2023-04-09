using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    /// <summary>
    /// this class manages usercontrol for viewing individual selected patient information.
    /// </summary>
    public partial class PatientDisplayInfoUserControl : UserControl
    {
        private Person thePatient;
        private PatientController _patientController;

        /// <summary>
        /// create constructors
        /// </summary>
        public PatientDisplayInfoUserControl()
        {
            InitializeComponent();
            this._patientController = new PatientController();
            this.thePatient = new Person();
        }

        /// <summary>
        /// setter patientID
        /// </summary>
        public string ID
        {
            set { patientIDTextBox.Text = value; }
        }

        private void patientIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.patientIDTextBox.Text != "0")
            {
                this.thePatient = this._patientController.GetPatientByID(int.Parse(this.patientIDTextBox.Text));
                this.lastNametextBox.Text = this.thePatient.LastName;
                this.firstNametextBox.Text = this.thePatient.FirstName;
                this.dobTextBox.Text = this.thePatient.DateOfBirth.ToShortDateString();
                this.phoneTextBox.Text = Regex.Replace(this.thePatient.Phone, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
                this.addressTextBox.Text = this.thePatient.AddressStreet;
                this.cityTextBox.Text = this.thePatient.City;
                this.stateTextBox.Text = this.thePatient.State;
                this.zipTextBox.Text = this.thePatient.Zip;
                this.genderTextBox.Text = this.thePatient.Sex;
                this.ssnTextBox.Text = this.thePatient.SSN;
            }
            else
            {
                this.ClearAllDataDisplay();
            }
        }

        private void ClearAllDataDisplay()
        {
            this.lastNametextBox.Text = "";
            this.firstNametextBox.Text = "";
            this.dobTextBox.Text = "";
            this.phoneTextBox.Text = "";
            this.addressTextBox.Text = "";
            this.cityTextBox.Text = "";
            this.stateTextBox.Text = "";
            this.zipTextBox.Text = "";
            this.genderTextBox.Text = "";
            this.ssnTextBox.Text = "";
        }
    }
}
