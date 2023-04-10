﻿using ClinicManagementApp.Controller;
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
        private readonly VisitController _visitController;
        private readonly DoctorController _doctorController;
        private readonly NurseController _nurseController;
        private readonly LabTestController _labTestController;
        private int _visitID;
        private List<PatientVisit> _patients;

        /// <summary>
        /// Constructor for labs user control
        /// </summary>
        public LabsUserControl()
        {
            InitializeComponent();
            _patientController = new PatientController();
            _visitID = -1;
            _visitController = new VisitController(); 
            _doctorController = new DoctorController();
            _nurseController = new NurseController();
            _patients = new List<PatientVisit>();
            _labTestController = new LabTestController();
            setGridComboBoxOptions();
        }

        private void AppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _patients = _patientController.GetPatientsByVisitDate(appointmentDateTimePicker.Value);

            if(_patients.Count > 0)
            {
                patientComboBox.DataSource = _patients;
            }
            else
            {
                MessageBox.Show("No patients with a visit on " + appointmentDateTimePicker.Value.ToString("dd/MM/yyyy"));
            }
        }

        private void patientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (_patients.Count > 0)
            {
                _visitID = _patients[patientComboBox.SelectedIndex].VisitID;
                Visit visit = _visitController.GetVisitInformationByVisitID(_visitID);

                patientBindingSource.Clear();
                patientBindingSource.DataSource = _patientController.GetPatientByID(visit.PatientID);

                doctorBindingSource.Clear();
                doctorBindingSource.DataSource = _doctorController.GetDoctorByID(visit.DoctorID);

                nurseBindingSource.Clear();
                nurseBindingSource.DataSource = _nurseController.GetNurseByID(visit.NurseID);

                labDataGridView.DataSource = _labTestController.GetLabTestListByVisitID(_visitID);
            }
        }

        private void setGridComboBoxOptions()
        {
            this.resultIsNormalDataGridViewComboBoxColumn.DataSource = new List<Range>
            {
                new Range {RangeInt = 0, RangeString = "Normal"},
                new Range {RangeInt = 1, RangeString = "Abnormal"}
            };

            this.resultIsNormalDataGridViewComboBoxColumn.DisplayMember = "RangeString";
            this.resultIsNormalDataGridViewComboBoxColumn.ValueMember = "RangeInt";
        }

        private void LabDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == labDataGridView.Columns["UpdateLabTestButton"].Index && e.RowIndex >= 0)
                {
                    //MessageBox.Show("Button clicked at row: " + e.RowIndex.ToString());

                    DataGridViewRow row = labDataGridView.Rows[e.RowIndex];
                    object datePerformed = row.Cells["testDateDataGridViewTextBoxColumn"].Value;
                    object result = row.Cells["resultDataGridViewTextBoxColumn"].Value;
                    object range = row.Cells["resultIsNormalDataGridViewComboBoxColumn"].Value;

                    if (datePerformed == null || string.IsNullOrEmpty(datePerformed.ToString()) ||
                        result == null || string.IsNullOrEmpty(result.ToString()) ||
                            range == null || string.IsNullOrEmpty(range.ToString()))
                    {
                        MessageBox.Show("Must fill out date performed, result, and range to submit.");
                    }
                    else if (!DateTime.TryParse(datePerformed.ToString(), out DateTime parsedDate))
                    {
                        MessageBox.Show("Must enter a valid date in the form of YYYY-MM-DD. Ex. 2023-03-11");
                    } 
                    else
                    {
                        LabTest testToUpdate = row.DataBoundItem as LabTest;
                        bool success = _labTestController.UpdateLabTest(testToUpdate);

                        if(success)
                        {
                            MessageBox.Show("Lab test successfully updated.");
                        }
                        else
                        {
                            MessageBox.Show("Warning: Lab Test not updated. Please check the entered values and try again. " +
                                "Range: " + testToUpdate.ResultIsNormal + " Date Performed: " + testToUpdate.TestDate + " Result: " + testToUpdate.Result
                            + " visitID: " + testToUpdate.VisitID + " Test Code: " + testToUpdate.TestCode);
                        }
                    }
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Must enter a valid date in the form of YYYY-MM-DD. Ex. 2023-03-11");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LabDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Must enter a valid date in the form of YYYY-MM-DD. Ex. 2023-03-11. " +
                    "Must fill out date performed, result, and range to submit.");
        }
    }
}