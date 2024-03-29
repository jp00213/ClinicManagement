﻿namespace ClinicManagementApp.UserControls
{
    partial class UpdatePatientInformationUserControl
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
            System.Windows.Forms.Label sSNLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.patientSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.lastNameResultsLabel = new System.Windows.Forms.Label();
            this.firstNameResultsLabel = new System.Windows.Forms.Label();
            this.DOBlabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.updatePatientButton = new System.Windows.Forms.Button();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.lastNameResultsTextBox = new System.Windows.Forms.TextBox();
            this.firstNameResultsTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.updatePatientLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.clearPatientButton = new System.Windows.Forms.Button();
            this.dateOfBirthResultsDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.cityErrorLabel = new System.Windows.Forms.Label();
            this.stateErrorLabel = new System.Windows.Forms.Label();
            this.zipErrorLabel = new System.Windows.Forms.Label();
            this.DOBErrorLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.sSNTextBox = new System.Windows.Forms.TextBox();
            this.sexErrorMessageLabel = new System.Windows.Forms.Label();
            this.ssnErrorMessageLabel = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            sSNLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientSearchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sSNLabel
            // 
            sSNLabel.AutoSize = true;
            sSNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            sSNLabel.Location = new System.Drawing.Point(411, 472);
            sSNLabel.Name = "sSNLabel";
            sSNLabel.Size = new System.Drawing.Size(45, 18);
            sSNLabel.TabIndex = 40;
            sSNLabel.Text = "SSN*";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            sexLabel.Location = new System.Drawing.Point(137, 505);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(33, 18);
            sexLabel.TabIndex = 42;
            sexLabel.Text = "Sex";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(15, 67);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(82, 16);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(18, 86);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(180, 67);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(81, 16);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(183, 86);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(161, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(370, 85);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(127, 24);
            this.dateOfBirthDateTimePicker.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(512, 77);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 31);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // patientSearchDataGridView
            // 
            this.patientSearchDataGridView.AllowUserToAddRows = false;
            this.patientSearchDataGridView.AllowUserToDeleteRows = false;
            this.patientSearchDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientSearchDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.patientSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientSearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
            this.patientSearchDataGridView.DataSource = this.patientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientSearchDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.patientSearchDataGridView.Location = new System.Drawing.Point(115, 120);
            this.patientSearchDataGridView.Name = "patientSearchDataGridView";
            this.patientSearchDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientSearchDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.patientSearchDataGridView.RowHeadersWidth = 51;
            this.patientSearchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientSearchDataGridView.Size = new System.Drawing.Size(558, 150);
            this.patientSearchDataGridView.TabIndex = 6;
            this.patientSearchDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientSearchDataGridView_CellClick);
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.AutoSize = true;
            this.patientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDLabel.Location = new System.Drawing.Point(99, 285);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(71, 18);
            this.patientIDLabel.TabIndex = 7;
            this.patientIDLabel.Text = "Patient ID";
            // 
            // lastNameResultsLabel
            // 
            this.lastNameResultsLabel.AutoSize = true;
            this.lastNameResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameResultsLabel.Location = new System.Drawing.Point(90, 331);
            this.lastNameResultsLabel.Name = "lastNameResultsLabel";
            this.lastNameResultsLabel.Size = new System.Drawing.Size(80, 18);
            this.lastNameResultsLabel.TabIndex = 8;
            this.lastNameResultsLabel.Text = "Last Name";
            // 
            // firstNameResultsLabel
            // 
            this.firstNameResultsLabel.AutoSize = true;
            this.firstNameResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameResultsLabel.Location = new System.Drawing.Point(89, 376);
            this.firstNameResultsLabel.Name = "firstNameResultsLabel";
            this.firstNameResultsLabel.Size = new System.Drawing.Size(81, 18);
            this.firstNameResultsLabel.TabIndex = 9;
            this.firstNameResultsLabel.Text = "First Name";
            // 
            // DOBlabel
            // 
            this.DOBlabel.AutoSize = true;
            this.DOBlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlabel.Location = new System.Drawing.Point(76, 428);
            this.DOBlabel.Name = "DOBlabel";
            this.DOBlabel.Size = new System.Drawing.Size(93, 18);
            this.DOBlabel.TabIndex = 10;
            this.DOBlabel.Text = "Date Of Birth";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(119, 472);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(51, 18);
            this.phoneLabel.TabIndex = 11;
            this.phoneLabel.Text = "Phone";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(407, 285);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 18);
            this.addressLabel.TabIndex = 12;
            this.addressLabel.Text = "Address";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(411, 333);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(33, 18);
            this.cityLabel.TabIndex = 13;
            this.cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(411, 374);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(42, 18);
            this.stateLabel.TabIndex = 14;
            this.stateLabel.Text = "State";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.Location = new System.Drawing.Point(411, 428);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(28, 18);
            this.zipLabel.TabIndex = 15;
            this.zipLabel.Text = "Zip";
            // 
            // updatePatientButton
            // 
            this.updatePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientButton.Location = new System.Drawing.Point(291, 550);
            this.updatePatientButton.Name = "updatePatientButton";
            this.updatePatientButton.Size = new System.Drawing.Size(187, 28);
            this.updatePatientButton.TabIndex = 29;
            this.updatePatientButton.Text = "Update Patient";
            this.updatePatientButton.UseVisualStyleBackColor = true;
            this.updatePatientButton.Click += new System.EventHandler(this.updatePatientButton_Click);
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "PatientID", true));
            this.patientIDTextBox.Location = new System.Drawing.Point(179, 285);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.ReadOnly = true;
            this.patientIDTextBox.Size = new System.Drawing.Size(186, 20);
            this.patientIDTextBox.TabIndex = 17;
            // 
            // lastNameResultsTextBox
            // 
            this.lastNameResultsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "LastName", true));
            this.lastNameResultsTextBox.Location = new System.Drawing.Point(179, 331);
            this.lastNameResultsTextBox.Name = "lastNameResultsTextBox";
            this.lastNameResultsTextBox.Size = new System.Drawing.Size(186, 20);
            this.lastNameResultsTextBox.TabIndex = 18;
            this.lastNameResultsTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // firstNameResultsTextBox
            // 
            this.firstNameResultsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "FirstName", true));
            this.firstNameResultsTextBox.Location = new System.Drawing.Point(179, 376);
            this.firstNameResultsTextBox.Name = "firstNameResultsTextBox";
            this.firstNameResultsTextBox.Size = new System.Drawing.Size(186, 20);
            this.firstNameResultsTextBox.TabIndex = 19;
            this.firstNameResultsTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(179, 472);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(186, 20);
            this.phoneTextBox.TabIndex = 21;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "AddressStreet", true));
            this.addressTextBox.Location = new System.Drawing.Point(478, 285);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(192, 20);
            this.addressTextBox.TabIndex = 23;
            this.addressTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(478, 331);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(192, 20);
            this.cityTextBox.TabIndex = 24;
            this.cityTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(478, 426);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(192, 20);
            this.zipTextBox.TabIndex = 26;
            this.zipTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // updatePatientLabel
            // 
            this.updatePatientLabel.AutoSize = true;
            this.updatePatientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientLabel.Location = new System.Drawing.Point(248, 25);
            this.updatePatientLabel.Name = "updatePatientLabel";
            this.updatePatientLabel.Size = new System.Drawing.Size(292, 25);
            this.updatePatientLabel.TabIndex = 26;
            this.updatePatientLabel.Text = "Update Patient Information";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(367, 66);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(39, 16);
            this.dateOfBirthLabel.TabIndex = 27;
            this.dateOfBirthLabel.Text = "DOB";
            // 
            // clearPatientButton
            // 
            this.clearPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearPatientButton.Location = new System.Drawing.Point(79, 550);
            this.clearPatientButton.Name = "clearPatientButton";
            this.clearPatientButton.Size = new System.Drawing.Size(187, 27);
            this.clearPatientButton.TabIndex = 28;
            this.clearPatientButton.Text = "Clear Patient";
            this.clearPatientButton.UseVisualStyleBackColor = true;
            this.clearPatientButton.Click += new System.EventHandler(this.clearPatientButton_Click);
            // 
            // dateOfBirthResultsDateTimePicker1
            // 
            this.dateOfBirthResultsDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "DateOfBirth", true));
            this.dateOfBirthResultsDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthResultsDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthResultsDateTimePicker1.Location = new System.Drawing.Point(179, 426);
            this.dateOfBirthResultsDateTimePicker1.Name = "dateOfBirthResultsDateTimePicker1";
            this.dateOfBirthResultsDateTimePicker1.Size = new System.Drawing.Size(186, 22);
            this.dateOfBirthResultsDateTimePicker1.TabIndex = 20;
            this.dateOfBirthResultsDateTimePicker1.DropDown += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(176, 355);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.lastNameErrorLabel.TabIndex = 32;
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(176, 400);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.firstNameErrorLabel.TabIndex = 33;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Location = new System.Drawing.Point(176, 496);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.phoneErrorLabel.TabIndex = 34;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Location = new System.Drawing.Point(478, 312);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.addressErrorLabel.TabIndex = 35;
            // 
            // cityErrorLabel
            // 
            this.cityErrorLabel.AutoSize = true;
            this.cityErrorLabel.Location = new System.Drawing.Point(478, 356);
            this.cityErrorLabel.Name = "cityErrorLabel";
            this.cityErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.cityErrorLabel.TabIndex = 36;
            // 
            // stateErrorLabel
            // 
            this.stateErrorLabel.AutoSize = true;
            this.stateErrorLabel.Location = new System.Drawing.Point(478, 402);
            this.stateErrorLabel.Name = "stateErrorLabel";
            this.stateErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.stateErrorLabel.TabIndex = 37;
            // 
            // zipErrorLabel
            // 
            this.zipErrorLabel.AutoSize = true;
            this.zipErrorLabel.Location = new System.Drawing.Point(478, 455);
            this.zipErrorLabel.Name = "zipErrorLabel";
            this.zipErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.zipErrorLabel.TabIndex = 38;
            // 
            // DOBErrorLabel
            // 
            this.DOBErrorLabel.AutoSize = true;
            this.DOBErrorLabel.Location = new System.Drawing.Point(176, 455);
            this.DOBErrorLabel.Name = "DOBErrorLabel";
            this.DOBErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.DOBErrorLabel.TabIndex = 39;
            this.DOBErrorLabel.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "State", true));
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateComboBox.Location = new System.Drawing.Point(478, 375);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(192, 21);
            this.stateComboBox.TabIndex = 25;
            // 
            // sSNTextBox
            // 
            this.sSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "SSN", true));
            this.sSNTextBox.Location = new System.Drawing.Point(478, 472);
            this.sSNTextBox.Name = "sSNTextBox";
            this.sSNTextBox.Size = new System.Drawing.Size(195, 20);
            this.sSNTextBox.TabIndex = 27;
            // 
            // sexErrorMessageLabel
            // 
            this.sexErrorMessageLabel.AutoSize = true;
            this.sexErrorMessageLabel.Location = new System.Drawing.Point(180, 541);
            this.sexErrorMessageLabel.Name = "sexErrorMessageLabel";
            this.sexErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.sexErrorMessageLabel.TabIndex = 41;
            // 
            // ssnErrorMessageLabel
            // 
            this.ssnErrorMessageLabel.AutoSize = true;
            this.ssnErrorMessageLabel.Location = new System.Drawing.Point(487, 496);
            this.ssnErrorMessageLabel.Name = "ssnErrorMessageLabel";
            this.ssnErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.ssnErrorMessageLabel.TabIndex = 42;
            // 
            // sexComboBox
            // 
            this.sexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Sex", true));
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(179, 505);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(186, 21);
            this.sexComboBox.TabIndex = 43;
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.clearSearchButton.Location = new System.Drawing.Point(631, 77);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(144, 31);
            this.clearSearchButton.TabIndex = 44;
            this.clearSearchButton.Text = "Clear Search";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatientButton.Location = new System.Drawing.Point(499, 550);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(187, 28);
            this.deletePatientButton.TabIndex = 45;
            this.deletePatientButton.Text = "Delete Patient";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            this.deletePatientButton.Click += new System.EventHandler(this.deletePatientButton_Click);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(ClinicManagementApp.Model.Patient);
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(ClinicManagementApp.Model.Person);
            // 
            // UpdatePatientInformationUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.deletePatientButton);
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.ssnErrorMessageLabel);
            this.Controls.Add(this.sexErrorMessageLabel);
            this.Controls.Add(sSNLabel);
            this.Controls.Add(this.sSNTextBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.DOBErrorLabel);
            this.Controls.Add(this.zipErrorLabel);
            this.Controls.Add(this.stateErrorLabel);
            this.Controls.Add(this.cityErrorLabel);
            this.Controls.Add(this.addressErrorLabel);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.dateOfBirthResultsDateTimePicker1);
            this.Controls.Add(this.clearPatientButton);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.updatePatientLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.firstNameResultsTextBox);
            this.Controls.Add(this.lastNameResultsTextBox);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(this.updatePatientButton);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.DOBlabel);
            this.Controls.Add(this.firstNameResultsLabel);
            this.Controls.Add(this.lastNameResultsLabel);
            this.Controls.Add(this.patientIDLabel);
            this.Controls.Add(this.patientSearchDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "UpdatePatientInformationUserControl";
            this.Size = new System.Drawing.Size(798, 598);
            ((System.ComponentModel.ISupportInitialize)(this.patientSearchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView patientSearchDataGridView;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.Label lastNameResultsLabel;
        private System.Windows.Forms.Label firstNameResultsLabel;
        private System.Windows.Forms.Label DOBlabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Button updatePatientButton;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.TextBox lastNameResultsTextBox;
        private System.Windows.Forms.TextBox firstNameResultsTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label updatePatientLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button clearPatientButton;
        private System.Windows.Forms.DateTimePicker dateOfBirthResultsDateTimePicker1;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.Label cityErrorLabel;
        private System.Windows.Forms.Label stateErrorLabel;
        private System.Windows.Forms.Label zipErrorLabel;
        private System.Windows.Forms.Label DOBErrorLabel;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox sSNTextBox;
        private System.Windows.Forms.Label sexErrorMessageLabel;
        private System.Windows.Forms.Label ssnErrorMessageLabel;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Button deletePatientButton;
    }
}
