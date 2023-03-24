
using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
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

        private void patientSearchButton_Click(object sender, EventArgs e)
        {
            this.SetPatientIDToZero();

            if ((firstAndLastNameRadio.Checked == true) && ((this.firstNameTextBox.Text == string.Empty) || (string.IsNullOrEmpty(this.lastNameTextBox.Text))))
                { 
                this.messageBox.Text = "Both First and Last Name cannot be empty.";
                return;
            }
            else if (lastDOBRadio.Checked == true)
            {
                if (string.IsNullOrEmpty(this.lastNameTextBox.Text))
                {
                    this.messageBox.Text = "Last Name cannot be empty.";
                    return;
                }
            }
            this.LoadPatientListView(this.firstNameTextBox.Text, this.lastNameTextBox.Text, this.dobDateTimePicker.Value);
        }

        private void SetPatientIDToZero()
        {
            this._controlNumber.PatientID = 0;
            this.patientListView.Items.Clear();
            // 5. event - event trigger
            this.OnNumberchanged(EventArgs.Empty);
        }
        private void TextBoxValidation()
        {
            if ((firstAndLastNameRadio.Checked == true) && (this.firstNameTextBox.Text == string.Empty) && (string.IsNullOrEmpty(this.lastNameTextBox.Text)))
            {
                this.messageBox.Text = "First and Last Name cannot be empty.";
            }
            else if (lastDOBRadio.Checked == true)
            {
                if (string.IsNullOrEmpty(this.lastNameTextBox.Text))
                {
                    this.messageBox.Text = "Last Name cannot be empty.";
                }
            }
        }

        private void patientListView_MouseClick(object sender, MouseEventArgs e)
        {
            patientIDShow.Text = patientListView.SelectedItems[0].SubItems[0].Text;
            this._controlNumber.PatientID = int.Parse(patientIDShow.Text);
            // 5. event - event trigger
            this.OnNumberchanged(EventArgs.Empty);

        }

        // 3. event - return current patientID
        protected virtual void OnNumberchanged(EventArgs e)
        {
            PatientNumberChanged?.Invoke(this, e);
        }

        // 4. event - return current patientID
        public string getCurrentpatientID()
        {
            return this._controlNumber.PatientID.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            SetPatientIDToZero();
            this.SetDefaultPageSetting();
        }

        private void firstAndLastNameRadio_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllBoxValue();
            dobLabel.Hide();
            dobDateTimePicker.Hide();
            firstNameLabel.Show();
            firstNameTextBox.Show();
            lastNameLabel.Show(); 
            lastNameTextBox.Show();
            this.patientSearchButton.Visible = true;
        }

        private void lastDOBRadio_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllBoxValue();
            firstNameLabel.Hide();
            firstNameTextBox.Hide();
            lastNameLabel.Show();
            lastNameTextBox.Show();
            dobDateTimePicker.Value = DateTime.Now.Date;
            dobLabel.Show();
            dobDateTimePicker.Show();
            this.patientSearchButton.Visible = true;
        }

        private void dobRadio_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllBoxValue();
            firstNameLabel.Hide();
            firstNameTextBox.Hide();
            lastNameLabel.Hide();
            lastNameTextBox.Hide();
            dobLabel.Show();
            dobDateTimePicker.Show();
            this.patientSearchButton.Visible = true;             
        }

        private void ClearAllBoxValue()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            dobDateTimePicker.Value = DateTime.Now.Date;
            this.messageBox.Text = "";
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.messageBox.Text = "";
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.messageBox.Text = "";
        }

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.messageBox.Text = "";
        }
    }
}
