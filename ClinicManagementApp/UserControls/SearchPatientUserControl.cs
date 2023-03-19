
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
            dobDateTimePicker.MaxDate = DateTime.Now.Date;
            dobDateTimePicker.CustomFormat = "yyyy / MM / dd";
            firstAndLastNameRadio.Checked = false;
            lastDOBRadio.Checked = false;
            dobRadio.Checked = false;
            firstNameTextBox.Text = string.Empty;
            firstNameLabel.Hide();
            firstNameTextBox.Hide();
            lastNameLabel.Hide();
            lastNameTextBox.Text = string.Empty;
            lastNameTextBox.Hide();
            dobLabel.Hide();
            dobDateTimePicker.Value = DateTime.Now.Date;
            dobDateTimePicker.Hide();
            this.messageBox.Text = "";
            this.patientSearchButton.Visible = false;
        }

        /// <summary>
        /// This method loads patient list in ListView
        /// </summary>
        /// <param name="firstNameIn">first name of patient</param>
        /// <param name="lastNameIn">last name of patient</param>
        /// <param name="dobIn">birthday of patient</param>
        public void LoadPatientListView(string firstNameIn, string lastNameIn, DateTime dobIn)
        {
            List<Patient> patientFoundList = this._patientController.GetPatientByInputsCheck(firstNameIn, lastNameIn, dobIn);

            if (patientFoundList.Count > 0)
            {
                this.messageBox.Text = "";
                this.patientListView.Items.Clear();
                Patient currentPatient;
                for(int i = 0; i < patientFoundList.Count; i++)
                {
                    currentPatient = patientFoundList[i];
                    patientListView.Items.Add(currentPatient.PatientID.ToString());
                    patientListView.Items[i].SubItems.Add(currentPatient.LastName);
                    patientListView.Items[i].SubItems.Add(currentPatient.FirstName);
                    patientListView.Items[i].SubItems.Add(currentPatient.DateOfBirth.ToShortDateString());
                }
            }
            else
            {
                this.messageBox.Text = "No patient found.";
            }
        }
    }
}
