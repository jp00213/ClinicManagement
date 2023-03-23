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
            appointmentDateTimePicker.CustomFormat = "yyyy / MM / dd";
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

        private void patientIDTextBox_TextChanged(object sender, EventArgs e)
        {
            appointListComboBox.DataSource = null;

            pastAppointmentComboBox.DataSource = null;

            if (this.GetFutureAppointmentCount() > 0)
            {
                this.ClearAllFutureAppointmentDetails();
                this.LoadFutureAppointmentComboBox();
                this.ClearFutureNoDataMessage();
            }
            else
            {
                this.ClearAllFutureAppointmentDetails();
                this.ShowFutureNoDataFoundMessage();
            }

            if (this.GetPastAppointmentCount() > 0)
            {
                this.ClearAllPastAppointmentDetails();
                this.LoadPastAppointmentComboBox();
                this.ClearPastNoDataMessage();
            }
            else
            {
                this.ClearAllPastAppointmentDetails();
                this.ShowPastNoDataFoundMessage();
            }
        }

        private void ShowFutureNoDataFoundMessage()
        {
            futureAppointmentMessageLabel.Text = "No records found.";
        }

        private void ClearFutureNoDataMessage()
        {
            futureAppointmentMessageLabel.Text = "";
        }

        private void ShowPastNoDataFoundMessage()
        {
            pastAppointmentMessageLabel.Text = "No records found.";
        }

        private void ClearPastNoDataMessage()
        {
            pastAppointmentMessageLabel.Text = "";
        }

        private int GetFutureAppointmentCount()
        {
            return this.appointmentController.GetAppointmentsByID_NowOn(int.Parse(patientIDTextBox.Text)).Count;
        }

        private int GetPastAppointmentCount()
        {
            return this.appointmentController.GetAppointmentsByID_Past(int.Parse(patientIDTextBox.Text)).Count;
        }

        private void LoadFutureAppointmentComboBox()
        {
            appointListComboBox.DataSource = this.appointmentController.GetAppointmentsByID_NowOn(int.Parse(patientIDTextBox.Text));
            appointListComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            appointListComboBox.DisplayMember = "appointmentSummary";
            appointListComboBox.ValueMember = "appointmentID";
            appointListComboBox.SelectedIndex = 0;
            theFutureAppointmentNumberTextBox.Text = this.appointListComboBox.SelectedValue.ToString();
        }

        private void LoadPastAppointmentComboBox()
        {
            pastAppointmentComboBox.DataSource = this.appointmentController.GetAppointmentsByID_Past(int.Parse(patientIDTextBox.Text));
            pastAppointmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pastAppointmentComboBox.DisplayMember = "appointmentSummary";
            pastAppointmentComboBox.ValueMember = "appointmentID";
            pastAppointmentComboBox.SelectedIndex = 0;
            pastAppointmentNumberTextBox.Text = this.pastAppointmentComboBox.SelectedValue.ToString();
        }

        private void appointListComboBox_ValueMemberChanged(object sender, EventArgs e)
        {
            this.ClearAllFutureAppointmentDetails();
            theFutureAppointmentNumberTextBox.Text = this.appointListComboBox.SelectedValue.ToString();
        }

        private void appointListComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ClearAllFutureAppointmentDetails();
            theFutureAppointmentNumberTextBox.Text = this.appointListComboBox.SelectedValue.ToString();
        }

        private void pastAppointmentComboBox_ValueMemberChanged(object sender, EventArgs e)
        {
            this.ClearAllPastAppointmentDetails();
            pastAppointmentNumberTextBox.Text = this.pastAppointmentComboBox.SelectedValue.ToString();
        }

        private void pastAppointmentComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pastAppointmentNumberTextBox.Text = this.pastAppointmentComboBox.SelectedValue.ToString();
        }

        private void theFutureAppointmentNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            this.setFuturePatientAppointmentDetails();
        }

        private void pastAppointmentNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            this.setPastPatientAppointmentDetails();
        }

        private void setFuturePatientAppointmentDetails()
        {
            if (theFutureAppointmentNumberTextBox.Text != "")
            {
                AppointmentWithDrName appointmentDetail = this.appointmentController.GetAppointmentByID(int.Parse(theFutureAppointmentNumberTextBox.Text));

                this.doctorName.Text = appointmentDetail.DoctorName.ToString();
                this.reasonTextArea.Text = appointmentDetail.Reason.ToString();
                this.appointmentDateTimePicker.Value = appointmentDetail.AppointmentDatetime;
                this.tempTime.Text = appointmentDetail.TimeInString;
            }
        }

        private void setPastPatientAppointmentDetails()
        {
            if (pastAppointmentNumberTextBox.Text != "")
            {
                AppointmentWithDrName appointmentDetail = this.appointmentController.GetAppointmentByID(int.Parse(pastAppointmentNumberTextBox.Text));

                pastAppointmentDoctorName.Text = appointmentDetail.DoctorName.ToString();
                pastAppointmentDateTextBox.Text = appointmentDetail.AppointmentDatetime.ToShortDateString() + ' ' + appointmentDetail.AppointmentDatetime.ToString("HH:mm");
                pastAppointmentReasonTextArea.Text = appointmentDetail.Reason.ToString();
            }
        }

        private void showFutureRadioButton_Click(object sender, EventArgs e)
        {
            appointmentTableLayout.RowStyles[1].Height = 0;
            appointmentTableLayout.RowStyles[0].Height = 1;
        }

        private void pastAppointmentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            appointmentTableLayout.RowStyles[0].Height = 0;
            appointmentTableLayout.RowStyles[1].Height = 1;
        }

        private void ClearAllFutureAppointmentDetails()
        {
            this.theFutureAppointmentNumberTextBox.Text = string.Empty;
            this.doctorName.Text = "";
            this.reasonTextArea.Text = "";
            this.appointmentDateTimePicker.CustomFormat = "yyyy / MM / dd";
            this.appointmentDateTimePicker.Value = DateTime.Now;
            this.tempTime.Text = "";
        }

        private void ClearAllPastAppointmentDetails()
        {
            this.pastAppointmentNumberTextBox.Text = string.Empty;
            this.pastAppointmentDoctorName.Text = "";
            this.pastAppointmentDateTextBox.Text = "";
            this.pastAppointmentReasonTextArea.Text = "";
        }
    }
}
