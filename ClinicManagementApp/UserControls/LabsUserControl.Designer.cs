namespace ClinicManagementApp.UserControls
{
    partial class LabsUserControl
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
            this.components = new System.ComponentModel.Container();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.patientLabel = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.activeNurseIDLabel = new System.Windows.Forms.Label();
            this.nurseIDLabel = new System.Windows.Forms.Label();
            this.activeNurseNameLabel = new System.Windows.Forms.Label();
            this.nurseNameLabel = new System.Windows.Forms.Label();
            this.nurseInfoLabel = new System.Windows.Forms.Label();
            this.activeSpecialtyLabel = new System.Windows.Forms.Label();
            this.specialtyLabel = new System.Windows.Forms.Label();
            this.activeDoctorIDLabel = new System.Windows.Forms.Label();
            this.doctorIDNumberLabel = new System.Windows.Forms.Label();
            this.dividerLabel3 = new System.Windows.Forms.Label();
            this.activeDoctorNameLabel = new System.Windows.Forms.Label();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.doctorInformationLabel = new System.Windows.Forms.Label();
            this.activeAddressLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.activePhoneLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.activeDOBLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.activeNameLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.patientInformationLabel = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labDataGridView = new System.Windows.Forms.DataGridView();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultIsNormalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.labDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(177, 36);
            this.appointmentDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointmentDateTimePicker.MaxDate = new System.DateTime(2023, 3, 28, 0, 0, 0, 0);
            this.appointmentDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(162, 24);
            this.appointmentDateTimePicker.TabIndex = 25;
            this.appointmentDateTimePicker.Value = new System.DateTime(2023, 3, 28, 0, 0, 0, 0);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(178, 11);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(142, 18);
            this.dateLabel.TabIndex = 26;
            this.dateLabel.Text = "Date of Appointment";
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Location = new System.Drawing.Point(404, 11);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(53, 18);
            this.patientLabel.TabIndex = 27;
            this.patientLabel.Text = "Patient";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(407, 34);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(192, 26);
            this.doctorComboBox.TabIndex = 33;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(645, 25);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(129, 35);
            this.selectButton.TabIndex = 34;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // activeNurseIDLabel
            // 
            this.activeNurseIDLabel.AutoSize = true;
            this.activeNurseIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeNurseIDLabel.Location = new System.Drawing.Point(615, 203);
            this.activeNurseIDLabel.Name = "activeNurseIDLabel";
            this.activeNurseIDLabel.Size = new System.Drawing.Size(0, 18);
            this.activeNurseIDLabel.TabIndex = 58;
            // 
            // nurseIDLabel
            // 
            this.nurseIDLabel.AutoSize = true;
            this.nurseIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseIDLabel.Location = new System.Drawing.Point(528, 203);
            this.nurseIDLabel.Name = "nurseIDLabel";
            this.nurseIDLabel.Size = new System.Drawing.Size(83, 18);
            this.nurseIDLabel.TabIndex = 57;
            this.nurseIDLabel.Text = "ID Number:";
            // 
            // activeNurseNameLabel
            // 
            this.activeNurseNameLabel.AutoSize = true;
            this.activeNurseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeNurseNameLabel.Location = new System.Drawing.Point(615, 178);
            this.activeNurseNameLabel.Name = "activeNurseNameLabel";
            this.activeNurseNameLabel.Size = new System.Drawing.Size(0, 18);
            this.activeNurseNameLabel.TabIndex = 56;
            // 
            // nurseNameLabel
            // 
            this.nurseNameLabel.AutoSize = true;
            this.nurseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseNameLabel.Location = new System.Drawing.Point(528, 178);
            this.nurseNameLabel.Name = "nurseNameLabel";
            this.nurseNameLabel.Size = new System.Drawing.Size(56, 18);
            this.nurseNameLabel.TabIndex = 55;
            this.nurseNameLabel.Text = "Name: ";
            // 
            // nurseInfoLabel
            // 
            this.nurseInfoLabel.AutoSize = true;
            this.nurseInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseInfoLabel.Location = new System.Drawing.Point(571, 151);
            this.nurseInfoLabel.Name = "nurseInfoLabel";
            this.nurseInfoLabel.Size = new System.Drawing.Size(143, 18);
            this.nurseInfoLabel.TabIndex = 54;
            this.nurseInfoLabel.Text = "Nurse Information";
            // 
            // activeSpecialtyLabel
            // 
            this.activeSpecialtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeSpecialtyLabel.Location = new System.Drawing.Point(360, 202);
            this.activeSpecialtyLabel.Name = "activeSpecialtyLabel";
            this.activeSpecialtyLabel.Size = new System.Drawing.Size(100, 23);
            this.activeSpecialtyLabel.TabIndex = 53;
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialtyLabel.Location = new System.Drawing.Point(268, 202);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(86, 23);
            this.specialtyLabel.TabIndex = 52;
            this.specialtyLabel.Text = "Specialty:";
            // 
            // activeDoctorIDLabel
            // 
            this.activeDoctorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDoctorIDLabel.Location = new System.Drawing.Point(178, 202);
            this.activeDoctorIDLabel.Name = "activeDoctorIDLabel";
            this.activeDoctorIDLabel.Size = new System.Drawing.Size(58, 23);
            this.activeDoctorIDLabel.TabIndex = 51;
            // 
            // doctorIDNumberLabel
            // 
            this.doctorIDNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorIDNumberLabel.Location = new System.Drawing.Point(125, 202);
            this.doctorIDNumberLabel.Name = "doctorIDNumberLabel";
            this.doctorIDNumberLabel.Size = new System.Drawing.Size(62, 23);
            this.doctorIDNumberLabel.TabIndex = 50;
            this.doctorIDNumberLabel.Text = "ID Number:";
            // 
            // dividerLabel3
            // 
            this.dividerLabel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dividerLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividerLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dividerLabel3.Location = new System.Drawing.Point(102, 145);
            this.dividerLabel3.Name = "dividerLabel3";
            this.dividerLabel3.Size = new System.Drawing.Size(750, 2);
            this.dividerLabel3.TabIndex = 49;
            // 
            // activeDoctorNameLabel
            // 
            this.activeDoctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDoctorNameLabel.Location = new System.Drawing.Point(215, 174);
            this.activeDoctorNameLabel.Name = "activeDoctorNameLabel";
            this.activeDoctorNameLabel.Size = new System.Drawing.Size(100, 15);
            this.activeDoctorNameLabel.TabIndex = 48;
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameLabel.Location = new System.Drawing.Point(142, 174);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(67, 27);
            this.doctorNameLabel.TabIndex = 47;
            this.doctorNameLabel.Text = "Name:";
            // 
            // doctorInformationLabel
            // 
            this.doctorInformationLabel.AutoSize = true;
            this.doctorInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorInformationLabel.Location = new System.Drawing.Point(196, 150);
            this.doctorInformationLabel.Name = "doctorInformationLabel";
            this.doctorInformationLabel.Size = new System.Drawing.Size(150, 18);
            this.doctorInformationLabel.TabIndex = 46;
            this.doctorInformationLabel.Text = "Doctor Information";
            // 
            // activeAddressLabel
            // 
            this.activeAddressLabel.AutoSize = true;
            this.activeAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeAddressLabel.Location = new System.Drawing.Point(696, 124);
            this.activeAddressLabel.Name = "activeAddressLabel";
            this.activeAddressLabel.Size = new System.Drawing.Size(0, 18);
            this.activeAddressLabel.TabIndex = 45;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(615, 124);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(66, 18);
            this.addressLabel.TabIndex = 44;
            this.addressLabel.Text = "Address:";
            // 
            // activePhoneLabel
            // 
            this.activePhoneLabel.AutoSize = true;
            this.activePhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activePhoneLabel.Location = new System.Drawing.Point(511, 124);
            this.activePhoneLabel.Name = "activePhoneLabel";
            this.activePhoneLabel.Size = new System.Drawing.Size(0, 18);
            this.activePhoneLabel.TabIndex = 43;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(450, 124);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(55, 18);
            this.phoneLabel.TabIndex = 42;
            this.phoneLabel.Text = "Phone:";
            // 
            // activeDOBLabel
            // 
            this.activeDOBLabel.AutoSize = true;
            this.activeDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDOBLabel.Location = new System.Drawing.Point(360, 124);
            this.activeDOBLabel.Name = "activeDOBLabel";
            this.activeDOBLabel.Size = new System.Drawing.Size(0, 18);
            this.activeDOBLabel.TabIndex = 41;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(305, 124);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(49, 18);
            this.dobLabel.TabIndex = 40;
            this.dobLabel.Text = "DOB: ";
            // 
            // activeNameLabel
            // 
            this.activeNameLabel.AutoSize = true;
            this.activeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeNameLabel.Location = new System.Drawing.Point(163, 124);
            this.activeNameLabel.Name = "activeNameLabel";
            this.activeNameLabel.Size = new System.Drawing.Size(0, 18);
            this.activeNameLabel.TabIndex = 39;
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(108, 124);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(52, 18);
            this.patientNameLabel.TabIndex = 38;
            this.patientNameLabel.Text = "Name:";
            // 
            // patientInformationLabel
            // 
            this.patientInformationLabel.AutoSize = true;
            this.patientInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInformationLabel.Location = new System.Drawing.Point(404, 99);
            this.patientInformationLabel.Name = "patientInformationLabel";
            this.patientInformationLabel.Size = new System.Drawing.Size(150, 18);
            this.patientInformationLabel.TabIndex = 37;
            this.patientInformationLabel.Text = "Patient Information";
            // 
            // dividerLabel
            // 
            this.dividerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dividerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dividerLabel.Location = new System.Drawing.Point(102, 88);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(750, 3);
            this.dividerLabel.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(102, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 3);
            this.label1.TabIndex = 59;
            // 
            // labDataGridView
            // 
            this.labDataGridView.AutoGenerateColumns = false;
            this.labDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.labDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testCodeDataGridViewTextBoxColumn,
            this.testNameDataGridViewTextBoxColumn,
            this.dateOrderedDataGridViewTextBoxColumn,
            this.testDateDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.resultIsNormalDataGridViewTextBoxColumn});
            this.labDataGridView.DataSource = this.labTestBindingSource;
            this.labDataGridView.Location = new System.Drawing.Point(38, 251);
            this.labDataGridView.Name = "labDataGridView";
            this.labDataGridView.Size = new System.Drawing.Size(852, 257);
            this.labDataGridView.TabIndex = 60;
            // 
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataSource = typeof(ClinicManagementApp.Model.LabTest);
            // 
            // testCodeDataGridViewTextBoxColumn
            // 
            this.testCodeDataGridViewTextBoxColumn.DataPropertyName = "TestCode";
            this.testCodeDataGridViewTextBoxColumn.HeaderText = "Test Code";
            this.testCodeDataGridViewTextBoxColumn.Name = "testCodeDataGridViewTextBoxColumn";
            this.testCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testNameDataGridViewTextBoxColumn
            // 
            this.testNameDataGridViewTextBoxColumn.DataPropertyName = "TestName";
            this.testNameDataGridViewTextBoxColumn.HeaderText = "Test Name";
            this.testNameDataGridViewTextBoxColumn.Name = "testNameDataGridViewTextBoxColumn";
            this.testNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOrderedDataGridViewTextBoxColumn
            // 
            this.dateOrderedDataGridViewTextBoxColumn.DataPropertyName = "DateOrdered";
            this.dateOrderedDataGridViewTextBoxColumn.HeaderText = "Date Ordered";
            this.dateOrderedDataGridViewTextBoxColumn.Name = "dateOrderedDataGridViewTextBoxColumn";
            this.dateOrderedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testDateDataGridViewTextBoxColumn
            // 
            this.testDateDataGridViewTextBoxColumn.DataPropertyName = "TestDate";
            this.testDateDataGridViewTextBoxColumn.HeaderText = "Date Performed";
            this.testDateDataGridViewTextBoxColumn.Name = "testDateDataGridViewTextBoxColumn";
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            // 
            // resultIsNormalDataGridViewTextBoxColumn
            // 
            this.resultIsNormalDataGridViewTextBoxColumn.DataPropertyName = "ResultIsNormal";
            this.resultIsNormalDataGridViewTextBoxColumn.HeaderText = "Range";
            this.resultIsNormalDataGridViewTextBoxColumn.Name = "resultIsNormalDataGridViewTextBoxColumn";
            // 
            // LabsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activeNurseIDLabel);
            this.Controls.Add(this.nurseIDLabel);
            this.Controls.Add(this.activeNurseNameLabel);
            this.Controls.Add(this.nurseNameLabel);
            this.Controls.Add(this.nurseInfoLabel);
            this.Controls.Add(this.activeSpecialtyLabel);
            this.Controls.Add(this.specialtyLabel);
            this.Controls.Add(this.activeDoctorIDLabel);
            this.Controls.Add(this.doctorIDNumberLabel);
            this.Controls.Add(this.dividerLabel3);
            this.Controls.Add(this.activeDoctorNameLabel);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.doctorInformationLabel);
            this.Controls.Add(this.activeAddressLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.activePhoneLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.activeDOBLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.activeNameLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.patientInformationLabel);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LabsUserControl";
            this.Size = new System.Drawing.Size(925, 542);
            this.Load += new System.EventHandler(this.LabsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label activeNurseIDLabel;
        private System.Windows.Forms.Label nurseIDLabel;
        private System.Windows.Forms.Label activeNurseNameLabel;
        private System.Windows.Forms.Label nurseNameLabel;
        private System.Windows.Forms.Label nurseInfoLabel;
        private System.Windows.Forms.Label activeSpecialtyLabel;
        private System.Windows.Forms.Label specialtyLabel;
        private System.Windows.Forms.Label activeDoctorIDLabel;
        private System.Windows.Forms.Label doctorIDNumberLabel;
        private System.Windows.Forms.Label dividerLabel3;
        private System.Windows.Forms.Label activeDoctorNameLabel;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Label doctorInformationLabel;
        private System.Windows.Forms.Label activeAddressLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label activePhoneLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label activeDOBLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label activeNameLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientInformationLabel;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView labDataGridView;
        private System.Windows.Forms.BindingSource labTestBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn testCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultIsNormalDataGridViewTextBoxColumn;
    }
}
