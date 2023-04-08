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
            System.Windows.Forms.Label addressStreetLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label phoneLabel;
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.patientLabel = new System.Windows.Forms.Label();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
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
            this.activePhoneLabel = new System.Windows.Forms.Label();
            this.activeDOBLabel = new System.Windows.Forms.Label();
            this.activeNameLabel = new System.Windows.Forms.Label();
            this.patientInformationLabel = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labDataGridView = new System.Windows.Forms.DataGridView();
            this.testCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultIsNormalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressStreetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            addressStreetLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.labDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressStreetLabel
            // 
            addressStreetLabel.AutoSize = true;
            addressStreetLabel.Enabled = false;
            addressStreetLabel.Location = new System.Drawing.Point(337, 124);
            addressStreetLabel.Name = "addressStreetLabel";
            addressStreetLabel.Size = new System.Drawing.Size(109, 18);
            addressStreetLabel.TabIndex = 60;
            addressStreetLabel.Text = "Address Street:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Enabled = false;
            cityLabel.Location = new System.Drawing.Point(615, 124);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(37, 18);
            cityLabel.TabIndex = 62;
            cityLabel.Text = "City:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Enabled = false;
            dateOfBirthLabel.Location = new System.Drawing.Point(480, 95);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(97, 18);
            dateOfBirthLabel.TabIndex = 64;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Enabled = false;
            firstNameLabel.Location = new System.Drawing.Point(105, 94);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(52, 18);
            firstNameLabel.TabIndex = 66;
            firstNameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Enabled = false;
            phoneLabel.Location = new System.Drawing.Point(109, 124);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 18);
            phoneLabel.TabIndex = 72;
            phoneLabel.Text = "Phone:";
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(177, 36);
            this.appointmentDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentDateTimePicker.MaxDate = new System.DateTime(2023, 3, 28, 0, 0, 0, 0);
            this.appointmentDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(162, 24);
            this.appointmentDateTimePicker.TabIndex = 25;
            this.appointmentDateTimePicker.Value = new System.DateTime(2023, 3, 28, 0, 0, 0, 0);
            this.appointmentDateTimePicker.ValueChanged += new System.EventHandler(this.AppointmentDateTimePicker_ValueChanged);
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
            // patientComboBox
            // 
            this.patientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(407, 34);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(192, 26);
            this.patientComboBox.TabIndex = 33;
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
            this.nurseInfoLabel.Location = new System.Drawing.Point(528, 151);
            this.nurseInfoLabel.Name = "nurseInfoLabel";
            this.nurseInfoLabel.Size = new System.Drawing.Size(143, 18);
            this.nurseInfoLabel.TabIndex = 54;
            this.nurseInfoLabel.Text = "Nurse Information";
            // 
            // activeSpecialtyLabel
            // 
            this.activeSpecialtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeSpecialtyLabel.Location = new System.Drawing.Point(374, 202);
            this.activeSpecialtyLabel.Name = "activeSpecialtyLabel";
            this.activeSpecialtyLabel.Size = new System.Drawing.Size(100, 23);
            this.activeSpecialtyLabel.TabIndex = 53;
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialtyLabel.Location = new System.Drawing.Point(282, 202);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(86, 23);
            this.specialtyLabel.TabIndex = 52;
            this.specialtyLabel.Text = "Specialty:";
            // 
            // activeDoctorIDLabel
            // 
            this.activeDoctorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDoctorIDLabel.Location = new System.Drawing.Point(201, 202);
            this.activeDoctorIDLabel.Name = "activeDoctorIDLabel";
            this.activeDoctorIDLabel.Size = new System.Drawing.Size(58, 23);
            this.activeDoctorIDLabel.TabIndex = 51;
            // 
            // doctorIDNumberLabel
            // 
            this.doctorIDNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorIDNumberLabel.Location = new System.Drawing.Point(109, 201);
            this.doctorIDNumberLabel.Name = "doctorIDNumberLabel";
            this.doctorIDNumberLabel.Size = new System.Drawing.Size(86, 23);
            this.doctorIDNumberLabel.TabIndex = 50;
            this.doctorIDNumberLabel.Text = "ID Number:";
            // 
            // dividerLabel3
            // 
            this.dividerLabel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dividerLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividerLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividerLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dividerLabel3.Location = new System.Drawing.Point(102, 147);
            this.dividerLabel3.Name = "dividerLabel3";
            this.dividerLabel3.Size = new System.Drawing.Size(750, 2);
            this.dividerLabel3.TabIndex = 49;
            // 
            // activeDoctorNameLabel
            // 
            this.activeDoctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDoctorNameLabel.Location = new System.Drawing.Point(229, 174);
            this.activeDoctorNameLabel.Name = "activeDoctorNameLabel";
            this.activeDoctorNameLabel.Size = new System.Drawing.Size(100, 15);
            this.activeDoctorNameLabel.TabIndex = 48;
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameLabel.Location = new System.Drawing.Point(110, 174);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(67, 27);
            this.doctorNameLabel.TabIndex = 47;
            this.doctorNameLabel.Text = "Name:";
            // 
            // doctorInformationLabel
            // 
            this.doctorInformationLabel.AutoSize = true;
            this.doctorInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorInformationLabel.Location = new System.Drawing.Point(110, 151);
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
            // activePhoneLabel
            // 
            this.activePhoneLabel.AutoSize = true;
            this.activePhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activePhoneLabel.Location = new System.Drawing.Point(526, 97);
            this.activePhoneLabel.Name = "activePhoneLabel";
            this.activePhoneLabel.Size = new System.Drawing.Size(0, 18);
            this.activePhoneLabel.TabIndex = 43;
            // 
            // activeDOBLabel
            // 
            this.activeDOBLabel.AutoSize = true;
            this.activeDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDOBLabel.Location = new System.Drawing.Point(375, 97);
            this.activeDOBLabel.Name = "activeDOBLabel";
            this.activeDOBLabel.Size = new System.Drawing.Size(0, 18);
            this.activeDOBLabel.TabIndex = 41;
            // 
            // activeNameLabel
            // 
            this.activeNameLabel.AutoSize = true;
            this.activeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeNameLabel.Location = new System.Drawing.Point(178, 97);
            this.activeNameLabel.Name = "activeNameLabel";
            this.activeNameLabel.Size = new System.Drawing.Size(0, 18);
            this.activeNameLabel.TabIndex = 39;
            // 
            // patientInformationLabel
            // 
            this.patientInformationLabel.AutoSize = true;
            this.patientInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInformationLabel.Location = new System.Drawing.Point(105, 70);
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
            this.labDataGridView.Location = new System.Drawing.Point(52, 250);
            this.labDataGridView.Name = "labDataGridView";
            this.labDataGridView.Size = new System.Drawing.Size(852, 257);
            this.labDataGridView.TabIndex = 60;
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
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataSource = typeof(ClinicManagementApp.Model.LabTest);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(ClinicManagementApp.Model.Patient);
            // 
            // addressStreetTextBox
            // 
            this.addressStreetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "AddressStreet", true));
            this.addressStreetTextBox.Enabled = false;
            this.addressStreetTextBox.Location = new System.Drawing.Point(452, 119);
            this.addressStreetTextBox.Name = "addressStreetTextBox";
            this.addressStreetTextBox.Size = new System.Drawing.Size(147, 24);
            this.addressStreetTextBox.TabIndex = 61;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "City", true));
            this.cityTextBox.Enabled = false;
            this.cityTextBox.Location = new System.Drawing.Point(658, 118);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(185, 24);
            this.cityTextBox.TabIndex = 63;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Enabled = false;
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(583, 91);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(103, 24);
            this.dateOfBirthDateTimePicker.TabIndex = 65;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "FirstName", true));
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Location = new System.Drawing.Point(154, 92);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(143, 24);
            this.firstNameTextBox.TabIndex = 67;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "LastName", true));
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(303, 91);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(143, 24);
            this.lastNameTextBox.TabIndex = 69;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Phone", true));
            this.phoneTextBox.Enabled = false;
            this.phoneTextBox.Location = new System.Drawing.Point(168, 118);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(148, 24);
            this.phoneTextBox.TabIndex = 73;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(ClinicManagementApp.Model.Doctor);
            // 
            // LabsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(addressStreetLabel);
            this.Controls.Add(this.addressStreetTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
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
            this.Controls.Add(this.activePhoneLabel);
            this.Controls.Add(this.activeDOBLabel);
            this.Controls.Add(this.activeNameLabel);
            this.Controls.Add(this.patientInformationLabel);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LabsUserControl";
            this.Size = new System.Drawing.Size(969, 542);
            ((System.ComponentModel.ISupportInitialize)(this.labDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.ComboBox patientComboBox;
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
        private System.Windows.Forms.Label activePhoneLabel;
        private System.Windows.Forms.Label activeDOBLabel;
        private System.Windows.Forms.Label activeNameLabel;
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
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.TextBox addressStreetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.BindingSource doctorBindingSource;
    }
}
