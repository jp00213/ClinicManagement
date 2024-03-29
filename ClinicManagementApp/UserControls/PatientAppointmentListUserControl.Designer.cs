﻿namespace ClinicManagementApp.UserControls
{
    partial class PatientAppointmentListUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.appointmentTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FutureAppointmentPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.doctorNameComboBox = new System.Windows.Forms.ComboBox();
            this.futureAppointmentMessageLabel = new System.Windows.Forms.Label();
            this.newTimeLabel = new System.Windows.Forms.Label();
            this.editAppointmentButton = new System.Windows.Forms.Button();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
            this.reasonTextArea = new System.Windows.Forms.TextBox();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tempTime = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.newAppointmentComboBox = new System.Windows.Forms.ComboBox();
            this.appointListComboBox = new System.Windows.Forms.ComboBox();
            this.theFutureAppointmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.futureAppointmentLabel = new System.Windows.Forms.Label();
            this.appointmentIDLabel = new System.Windows.Forms.Label();
            this.pastAppointmentPanel = new System.Windows.Forms.Panel();
            this.pastAppointmentMessageLabel = new System.Windows.Forms.Label();
            this.pastAppointmentReasonTextArea = new System.Windows.Forms.TextBox();
            this.pastAppointmentDateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pastAppointmentDoctorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pastAppointmentComboBox = new System.Windows.Forms.ComboBox();
            this.pastAppointmentLabel = new System.Windows.Forms.Label();
            this.pastAppointmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showFutureRadioButton = new System.Windows.Forms.RadioButton();
            this.pastAppointmentRadioButton = new System.Windows.Forms.RadioButton();
            this.AppoinmentUserControlLabel = new System.Windows.Forms.Label();
            this.deletePastAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentTableLayout.SuspendLayout();
            this.FutureAppointmentPanel.SuspendLayout();
            this.pastAppointmentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.AutoSize = true;
            this.patientIDLabel.Location = new System.Drawing.Point(23, 23);
            this.patientIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(57, 13);
            this.patientIDLabel.TabIndex = 5;
            this.patientIDLabel.Text = "Patient ID:";
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientIDTextBox.Location = new System.Drawing.Point(93, 23);
            this.patientIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.ReadOnly = true;
            this.patientIDTextBox.Size = new System.Drawing.Size(67, 13);
            this.patientIDTextBox.TabIndex = 3;
            this.patientIDTextBox.TextChanged += new System.EventHandler(this.patientIDTextBox_TextChanged);
            // 
            // appointmentTableLayout
            // 
            this.appointmentTableLayout.ColumnCount = 1;
            this.appointmentTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.appointmentTableLayout.Controls.Add(this.FutureAppointmentPanel, 0, 0);
            this.appointmentTableLayout.Controls.Add(this.pastAppointmentPanel, 0, 1);
            this.appointmentTableLayout.Location = new System.Drawing.Point(12, 39);
            this.appointmentTableLayout.Name = "appointmentTableLayout";
            this.appointmentTableLayout.RowCount = 2;
            this.appointmentTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.appointmentTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.appointmentTableLayout.Size = new System.Drawing.Size(589, 469);
            this.appointmentTableLayout.TabIndex = 6;
            // 
            // FutureAppointmentPanel
            // 
            this.FutureAppointmentPanel.Controls.Add(this.cancelButton);
            this.FutureAppointmentPanel.Controls.Add(this.saveButton);
            this.FutureAppointmentPanel.Controls.Add(this.doctorNameComboBox);
            this.FutureAppointmentPanel.Controls.Add(this.futureAppointmentMessageLabel);
            this.FutureAppointmentPanel.Controls.Add(this.newTimeLabel);
            this.FutureAppointmentPanel.Controls.Add(this.editAppointmentButton);
            this.FutureAppointmentPanel.Controls.Add(this.deleteAppointmentButton);
            this.FutureAppointmentPanel.Controls.Add(this.reasonTextArea);
            this.FutureAppointmentPanel.Controls.Add(this.appointmentDateTimePicker);
            this.FutureAppointmentPanel.Controls.Add(this.tempTime);
            this.FutureAppointmentPanel.Controls.Add(this.dateLabel);
            this.FutureAppointmentPanel.Controls.Add(this.newAppointmentComboBox);
            this.FutureAppointmentPanel.Controls.Add(this.appointListComboBox);
            this.FutureAppointmentPanel.Controls.Add(this.theFutureAppointmentNumberTextBox);
            this.FutureAppointmentPanel.Controls.Add(this.reasonLabel);
            this.FutureAppointmentPanel.Controls.Add(this.timeLabel);
            this.FutureAppointmentPanel.Controls.Add(this.doctorLabel);
            this.FutureAppointmentPanel.Controls.Add(this.futureAppointmentLabel);
            this.FutureAppointmentPanel.Controls.Add(this.appointmentIDLabel);
            this.FutureAppointmentPanel.Location = new System.Drawing.Point(2, 2);
            this.FutureAppointmentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FutureAppointmentPanel.Name = "FutureAppointmentPanel";
            this.FutureAppointmentPanel.Size = new System.Drawing.Size(585, 226);
            this.FutureAppointmentPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(20, 150);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 25);
            this.cancelButton.TabIndex = 31;
            this.cancelButton.Text = "Cancel Changes";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(156, 150);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 25);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // doctorNameComboBox
            // 
            this.doctorNameComboBox.Enabled = false;
            this.doctorNameComboBox.FormattingEnabled = true;
            this.doctorNameComboBox.Location = new System.Drawing.Point(120, 53);
            this.doctorNameComboBox.Name = "doctorNameComboBox";
            this.doctorNameComboBox.Size = new System.Drawing.Size(135, 21);
            this.doctorNameComboBox.TabIndex = 29;
            this.doctorNameComboBox.SelectedIndexChanged += new System.EventHandler(this.DoctorNameComboBox_SelectedIndexChanged);
            // 
            // futureAppointmentMessageLabel
            // 
            this.futureAppointmentMessageLabel.AutoSize = true;
            this.futureAppointmentMessageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.futureAppointmentMessageLabel.Location = new System.Drawing.Point(228, 7);
            this.futureAppointmentMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.futureAppointmentMessageLabel.Name = "futureAppointmentMessageLabel";
            this.futureAppointmentMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.futureAppointmentMessageLabel.TabIndex = 22;
            // 
            // newTimeLabel
            // 
            this.newTimeLabel.AutoSize = true;
            this.newTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTimeLabel.Location = new System.Drawing.Point(2, 128);
            this.newTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newTimeLabel.Name = "newTimeLabel";
            this.newTimeLabel.Size = new System.Drawing.Size(159, 15);
            this.newTimeLabel.TabIndex = 28;
            this.newTimeLabel.Text = "New Appointment Time:";
            // 
            // editAppointmentButton
            // 
            this.editAppointmentButton.Location = new System.Drawing.Point(156, 150);
            this.editAppointmentButton.Margin = new System.Windows.Forms.Padding(2);
            this.editAppointmentButton.Name = "editAppointmentButton";
            this.editAppointmentButton.Size = new System.Drawing.Size(121, 25);
            this.editAppointmentButton.TabIndex = 27;
            this.editAppointmentButton.Text = "Edit Appointment";
            this.editAppointmentButton.UseVisualStyleBackColor = true;
            this.editAppointmentButton.Click += new System.EventHandler(this.EditAppointmentButton_Click);
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.Location = new System.Drawing.Point(20, 150);
            this.deleteAppointmentButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(121, 25);
            this.deleteAppointmentButton.TabIndex = 13;
            this.deleteAppointmentButton.Text = "Delete Appointment";
            this.deleteAppointmentButton.UseVisualStyleBackColor = true;
            this.deleteAppointmentButton.Click += new System.EventHandler(this.deleteAppointmentButton_Click);
            // 
            // reasonTextArea
            // 
            this.reasonTextArea.Enabled = false;
            this.reasonTextArea.Location = new System.Drawing.Point(322, 53);
            this.reasonTextArea.Margin = new System.Windows.Forms.Padding(2);
            this.reasonTextArea.Multiline = true;
            this.reasonTextArea.Name = "reasonTextArea";
            this.reasonTextArea.Size = new System.Drawing.Size(178, 122);
            this.reasonTextArea.TabIndex = 9;
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.Enabled = false;
            this.appointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(120, 77);
            this.appointmentDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.appointmentDateTimePicker.TabIndex = 8;
            this.appointmentDateTimePicker.ValueChanged += new System.EventHandler(this.AppointmentDateTimePicker_ValueChanged);
            // 
            // tempTime
            // 
            this.tempTime.Enabled = false;
            this.tempTime.Location = new System.Drawing.Point(120, 101);
            this.tempTime.Margin = new System.Windows.Forms.Padding(2);
            this.tempTime.Name = "tempTime";
            this.tempTime.Size = new System.Drawing.Size(135, 20);
            this.tempTime.TabIndex = 19;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(83, 77);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 26;
            this.dateLabel.Text = "Date:";
            // 
            // newAppointmentComboBox
            // 
            this.newAppointmentComboBox.DropDownWidth = 223;
            this.newAppointmentComboBox.Enabled = false;
            this.newAppointmentComboBox.FormattingEnabled = true;
            this.newAppointmentComboBox.Location = new System.Drawing.Point(120, 125);
            this.newAppointmentComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.newAppointmentComboBox.Name = "newAppointmentComboBox";
            this.newAppointmentComboBox.Size = new System.Drawing.Size(135, 21);
            this.newAppointmentComboBox.TabIndex = 25;
            // 
            // appointListComboBox
            // 
            this.appointListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appointListComboBox.DropDownWidth = 223;
            this.appointListComboBox.FormattingEnabled = true;
            this.appointListComboBox.Location = new System.Drawing.Point(120, 28);
            this.appointListComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.appointListComboBox.Name = "appointListComboBox";
            this.appointListComboBox.Size = new System.Drawing.Size(223, 21);
            this.appointListComboBox.TabIndex = 5;
            this.appointListComboBox.SelectionChangeCommitted += new System.EventHandler(this.appointListComboBox_SelectionChangeCommitted);
            this.appointListComboBox.ValueMemberChanged += new System.EventHandler(this.appointListComboBox_ValueMemberChanged);
            // 
            // theFutureAppointmentNumberTextBox
            // 
            this.theFutureAppointmentNumberTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.theFutureAppointmentNumberTextBox.Location = new System.Drawing.Point(120, 4);
            this.theFutureAppointmentNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.theFutureAppointmentNumberTextBox.Name = "theFutureAppointmentNumberTextBox";
            this.theFutureAppointmentNumberTextBox.ReadOnly = true;
            this.theFutureAppointmentNumberTextBox.Size = new System.Drawing.Size(68, 20);
            this.theFutureAppointmentNumberTextBox.TabIndex = 18;
            this.theFutureAppointmentNumberTextBox.TextChanged += new System.EventHandler(this.theFutureAppointmentNumberTextBox_TextChanged);
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Location = new System.Drawing.Point(271, 56);
            this.reasonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(47, 13);
            this.reasonLabel.TabIndex = 10;
            this.reasonLabel.Text = "Reason:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(21, 104);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(95, 13);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "Appointment Time:";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(71, 53);
            this.doctorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(42, 13);
            this.doctorLabel.TabIndex = 6;
            this.doctorLabel.Text = "Doctor:";
            // 
            // futureAppointmentLabel
            // 
            this.futureAppointmentLabel.AutoSize = true;
            this.futureAppointmentLabel.Location = new System.Drawing.Point(10, 31);
            this.futureAppointmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.futureAppointmentLabel.Name = "futureAppointmentLabel";
            this.futureAppointmentLabel.Size = new System.Drawing.Size(107, 13);
            this.futureAppointmentLabel.TabIndex = 23;
            this.futureAppointmentLabel.Text = "Future Appointments:";
            // 
            // appointmentIDLabel
            // 
            this.appointmentIDLabel.AutoSize = true;
            this.appointmentIDLabel.Location = new System.Drawing.Point(37, 7);
            this.appointmentIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appointmentIDLabel.Name = "appointmentIDLabel";
            this.appointmentIDLabel.Size = new System.Drawing.Size(79, 13);
            this.appointmentIDLabel.TabIndex = 15;
            this.appointmentIDLabel.Text = "Appointment #:";
            // 
            // pastAppointmentPanel
            // 
            this.pastAppointmentPanel.Controls.Add(this.deletePastAppointmentButton);
            this.pastAppointmentPanel.Controls.Add(this.pastAppointmentMessageLabel);
            this.pastAppointmentPanel.Controls.Add(this.pastAppointmentReasonTextArea);
            this.pastAppointmentPanel.Controls.Add(this.pastAppointmentDateTextBox);
            this.pastAppointmentPanel.Controls.Add(this.label4);
            this.pastAppointmentPanel.Controls.Add(this.label3);
            this.pastAppointmentPanel.Controls.Add(this.pastAppointmentDoctorName);
            this.pastAppointmentPanel.Controls.Add(this.label2);
            this.pastAppointmentPanel.Controls.Add(this.pastAppointmentComboBox);
            this.pastAppointmentPanel.Controls.Add(this.pastAppointmentLabel);
            this.pastAppointmentPanel.Controls.Add(this.pastAppointmentNumberTextBox);
            this.pastAppointmentPanel.Controls.Add(this.label1);
            this.pastAppointmentPanel.Location = new System.Drawing.Point(2, 236);
            this.pastAppointmentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pastAppointmentPanel.Name = "pastAppointmentPanel";
            this.pastAppointmentPanel.Size = new System.Drawing.Size(585, 225);
            this.pastAppointmentPanel.TabIndex = 1;
            // 
            // pastAppointmentMessageLabel
            // 
            this.pastAppointmentMessageLabel.AutoSize = true;
            this.pastAppointmentMessageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pastAppointmentMessageLabel.Location = new System.Drawing.Point(228, 19);
            this.pastAppointmentMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pastAppointmentMessageLabel.Name = "pastAppointmentMessageLabel";
            this.pastAppointmentMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.pastAppointmentMessageLabel.TabIndex = 36;
            // 
            // pastAppointmentReasonTextArea
            // 
            this.pastAppointmentReasonTextArea.BackColor = System.Drawing.SystemColors.Control;
            this.pastAppointmentReasonTextArea.Location = new System.Drawing.Point(322, 65);
            this.pastAppointmentReasonTextArea.Margin = new System.Windows.Forms.Padding(2);
            this.pastAppointmentReasonTextArea.Multiline = true;
            this.pastAppointmentReasonTextArea.Name = "pastAppointmentReasonTextArea";
            this.pastAppointmentReasonTextArea.ReadOnly = true;
            this.pastAppointmentReasonTextArea.Size = new System.Drawing.Size(178, 106);
            this.pastAppointmentReasonTextArea.TabIndex = 36;
            // 
            // pastAppointmentDateTextBox
            // 
            this.pastAppointmentDateTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.pastAppointmentDateTextBox.Location = new System.Drawing.Point(120, 90);
            this.pastAppointmentDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pastAppointmentDateTextBox.Name = "pastAppointmentDateTextBox";
            this.pastAppointmentDateTextBox.ReadOnly = true;
            this.pastAppointmentDateTextBox.Size = new System.Drawing.Size(135, 20);
            this.pastAppointmentDateTextBox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Reason:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date:";
            // 
            // pastAppointmentDoctorName
            // 
            this.pastAppointmentDoctorName.BackColor = System.Drawing.SystemColors.Control;
            this.pastAppointmentDoctorName.Location = new System.Drawing.Point(120, 66);
            this.pastAppointmentDoctorName.Margin = new System.Windows.Forms.Padding(2);
            this.pastAppointmentDoctorName.Name = "pastAppointmentDoctorName";
            this.pastAppointmentDoctorName.ReadOnly = true;
            this.pastAppointmentDoctorName.Size = new System.Drawing.Size(135, 20);
            this.pastAppointmentDoctorName.TabIndex = 27;
            this.pastAppointmentDoctorName.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Doctor:";
            // 
            // pastAppointmentComboBox
            // 
            this.pastAppointmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pastAppointmentComboBox.DropDownWidth = 223;
            this.pastAppointmentComboBox.FormattingEnabled = true;
            this.pastAppointmentComboBox.Location = new System.Drawing.Point(120, 40);
            this.pastAppointmentComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.pastAppointmentComboBox.Name = "pastAppointmentComboBox";
            this.pastAppointmentComboBox.Size = new System.Drawing.Size(223, 21);
            this.pastAppointmentComboBox.TabIndex = 24;
            this.pastAppointmentComboBox.SelectionChangeCommitted += new System.EventHandler(this.pastAppointmentComboBox_SelectionChangeCommitted);
            this.pastAppointmentComboBox.ValueMemberChanged += new System.EventHandler(this.pastAppointmentComboBox_ValueMemberChanged);
            // 
            // pastAppointmentLabel
            // 
            this.pastAppointmentLabel.AutoSize = true;
            this.pastAppointmentLabel.Location = new System.Drawing.Point(18, 43);
            this.pastAppointmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pastAppointmentLabel.Name = "pastAppointmentLabel";
            this.pastAppointmentLabel.Size = new System.Drawing.Size(98, 13);
            this.pastAppointmentLabel.TabIndex = 25;
            this.pastAppointmentLabel.Text = "Past Appointments:";
            // 
            // pastAppointmentNumberTextBox
            // 
            this.pastAppointmentNumberTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.pastAppointmentNumberTextBox.Location = new System.Drawing.Point(120, 16);
            this.pastAppointmentNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pastAppointmentNumberTextBox.Name = "pastAppointmentNumberTextBox";
            this.pastAppointmentNumberTextBox.ReadOnly = true;
            this.pastAppointmentNumberTextBox.Size = new System.Drawing.Size(68, 20);
            this.pastAppointmentNumberTextBox.TabIndex = 20;
            this.pastAppointmentNumberTextBox.TextChanged += new System.EventHandler(this.pastAppointmentNumberTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Appointment #:";
            // 
            // showFutureRadioButton
            // 
            this.showFutureRadioButton.AutoSize = true;
            this.showFutureRadioButton.Location = new System.Drawing.Point(258, 17);
            this.showFutureRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.showFutureRadioButton.Name = "showFutureRadioButton";
            this.showFutureRadioButton.Size = new System.Drawing.Size(122, 17);
            this.showFutureRadioButton.TabIndex = 23;
            this.showFutureRadioButton.TabStop = true;
            this.showFutureRadioButton.Text = "Future Appointments";
            this.showFutureRadioButton.UseVisualStyleBackColor = true;
            this.showFutureRadioButton.Click += new System.EventHandler(this.showFutureRadioButton_Click);
            // 
            // pastAppointmentRadioButton
            // 
            this.pastAppointmentRadioButton.AutoSize = true;
            this.pastAppointmentRadioButton.Location = new System.Drawing.Point(401, 17);
            this.pastAppointmentRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.pastAppointmentRadioButton.Name = "pastAppointmentRadioButton";
            this.pastAppointmentRadioButton.Size = new System.Drawing.Size(113, 17);
            this.pastAppointmentRadioButton.TabIndex = 24;
            this.pastAppointmentRadioButton.TabStop = true;
            this.pastAppointmentRadioButton.Text = "Past Appointments";
            this.pastAppointmentRadioButton.UseVisualStyleBackColor = true;
            this.pastAppointmentRadioButton.CheckedChanged += new System.EventHandler(this.pastAppointmentRadioButton_CheckedChanged);
            // 
            // AppoinmentUserControlLabel
            // 
            this.AppoinmentUserControlLabel.AutoSize = true;
            this.AppoinmentUserControlLabel.Location = new System.Drawing.Point(23, 0);
            this.AppoinmentUserControlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppoinmentUserControlLabel.Name = "AppoinmentUserControlLabel";
            this.AppoinmentUserControlLabel.Size = new System.Drawing.Size(142, 13);
            this.AppoinmentUserControlLabel.TabIndex = 25;
            this.AppoinmentUserControlLabel.Text = "Patient Appointments Details";
            // 
            // deletePastAppointmentButton
            // 
            this.deletePastAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePastAppointmentButton.Location = new System.Drawing.Point(120, 141);
            this.deletePastAppointmentButton.Name = "deletePastAppointmentButton";
            this.deletePastAppointmentButton.Size = new System.Drawing.Size(135, 30);
            this.deletePastAppointmentButton.TabIndex = 37;
            this.deletePastAppointmentButton.Text = "Delete Appointment";
            this.deletePastAppointmentButton.UseVisualStyleBackColor = true;
            this.deletePastAppointmentButton.Click += new System.EventHandler(this.deletePastAppointmentButton_Click);
            // 
            // PatientAppointmentListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AppoinmentUserControlLabel);
            this.Controls.Add(this.pastAppointmentRadioButton);
            this.Controls.Add(this.showFutureRadioButton);
            this.Controls.Add(this.appointmentTableLayout);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(this.patientIDLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PatientAppointmentListUserControl";
            this.Size = new System.Drawing.Size(615, 509);
            this.appointmentTableLayout.ResumeLayout(false);
            this.FutureAppointmentPanel.ResumeLayout(false);
            this.FutureAppointmentPanel.PerformLayout();
            this.pastAppointmentPanel.ResumeLayout(false);
            this.pastAppointmentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.TableLayoutPanel appointmentTableLayout;
        private System.Windows.Forms.Panel FutureAppointmentPanel;
        private System.Windows.Forms.Panel pastAppointmentPanel;
        public System.Windows.Forms.RadioButton showFutureRadioButton;
        public System.Windows.Forms.RadioButton pastAppointmentRadioButton;
        private System.Windows.Forms.Label appointmentIDLabel;
        private System.Windows.Forms.Label futureAppointmentLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.TextBox theFutureAppointmentNumberTextBox;
        private System.Windows.Forms.Label AppoinmentUserControlLabel;
        private System.Windows.Forms.ComboBox appointListComboBox;
        private System.Windows.Forms.ComboBox newAppointmentComboBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox tempTime;
        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.TextBox reasonTextArea;
        private System.Windows.Forms.ComboBox pastAppointmentComboBox;
        private System.Windows.Forms.Label pastAppointmentLabel;
        private System.Windows.Forms.TextBox pastAppointmentNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pastAppointmentDoctorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pastAppointmentDateTextBox;
        private System.Windows.Forms.TextBox pastAppointmentReasonTextArea;
        private System.Windows.Forms.Button deleteAppointmentButton;
        private System.Windows.Forms.Button editAppointmentButton;
        private System.Windows.Forms.Label newTimeLabel;
        private System.Windows.Forms.Label futureAppointmentMessageLabel;
        private System.Windows.Forms.Label pastAppointmentMessageLabel;
        private System.Windows.Forms.ComboBox doctorNameComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deletePastAppointmentButton;
    }
}
