namespace ClinicManagementApp.UserControls
{
    partial class UpdateNurseUserControl
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
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label nurseIDLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label sSNLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label zipLabel;
            this.messageLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchFirstNameLabel = new System.Windows.Forms.Label();
            this.searchLastNameLabel = new System.Windows.Forms.Label();
            this.searchFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.searchLastNameTextBox = new System.Windows.Forms.TextBox();
            this.nurseDataGridView = new System.Windows.Forms.DataGridView();
            this.addressStreetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.isActiveTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.nurseIDTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.sSNTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.updateUserPasswordButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nurseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addressStreetLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            nurseIDLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            sSNLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nurseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(720, 44);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 18);
            this.messageLabel.TabIndex = 46;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(782, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 29);
            this.searchButton.TabIndex = 45;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchFirstNameLabel
            // 
            this.searchFirstNameLabel.AutoSize = true;
            this.searchFirstNameLabel.Location = new System.Drawing.Point(425, 20);
            this.searchFirstNameLabel.Name = "searchFirstNameLabel";
            this.searchFirstNameLabel.Size = new System.Drawing.Size(81, 18);
            this.searchFirstNameLabel.TabIndex = 44;
            this.searchFirstNameLabel.Text = "First Name";
            // 
            // searchLastNameLabel
            // 
            this.searchLastNameLabel.AutoSize = true;
            this.searchLastNameLabel.Location = new System.Drawing.Point(113, 20);
            this.searchLastNameLabel.Name = "searchLastNameLabel";
            this.searchLastNameLabel.Size = new System.Drawing.Size(80, 18);
            this.searchLastNameLabel.TabIndex = 43;
            this.searchLastNameLabel.Text = "Last Name";
            // 
            // searchFirstNameTextBox
            // 
            this.searchFirstNameTextBox.Location = new System.Drawing.Point(522, 14);
            this.searchFirstNameTextBox.Name = "searchFirstNameTextBox";
            this.searchFirstNameTextBox.Size = new System.Drawing.Size(193, 24);
            this.searchFirstNameTextBox.TabIndex = 42;
            // 
            // searchLastNameTextBox
            // 
            this.searchLastNameTextBox.Location = new System.Drawing.Point(213, 14);
            this.searchLastNameTextBox.Name = "searchLastNameTextBox";
            this.searchLastNameTextBox.Size = new System.Drawing.Size(185, 24);
            this.searchLastNameTextBox.TabIndex = 41;
            // 
            // nurseDataGridView
            // 
            this.nurseDataGridView.AllowUserToAddRows = false;
            this.nurseDataGridView.AllowUserToDeleteRows = false;
            this.nurseDataGridView.AutoGenerateColumns = false;
            this.nurseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nurseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nurseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nurseIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.nurseDataGridView.DataSource = this.nurseBindingSource;
            this.nurseDataGridView.Location = new System.Drawing.Point(107, 75);
            this.nurseDataGridView.Name = "nurseDataGridView";
            this.nurseDataGridView.ReadOnly = true;
            this.nurseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nurseDataGridView.Size = new System.Drawing.Size(786, 119);
            this.nurseDataGridView.TabIndex = 40;
            // 
            // addressStreetLabel
            // 
            addressStreetLabel.AutoSize = true;
            addressStreetLabel.Location = new System.Drawing.Point(510, 223);
            addressStreetLabel.Name = "addressStreetLabel";
            addressStreetLabel.Size = new System.Drawing.Size(109, 18);
            addressStreetLabel.TabIndex = 46;
            addressStreetLabel.Text = "Address Street:";
            // 
            // addressStreetTextBox
            // 
            this.addressStreetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "AddressStreet", true));
            this.addressStreetTextBox.Location = new System.Drawing.Point(625, 220);
            this.addressStreetTextBox.Name = "addressStreetTextBox";
            this.addressStreetTextBox.Size = new System.Drawing.Size(266, 24);
            this.addressStreetTextBox.TabIndex = 47;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(510, 253);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(37, 18);
            cityLabel.TabIndex = 48;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(625, 250);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(266, 24);
            this.cityTextBox.TabIndex = 49;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(109, 251);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(97, 18);
            dateOfBirthLabel.TabIndex = 50;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nurseBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Enabled = false;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(224, 247);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(266, 24);
            this.dateOfBirthDateTimePicker.TabIndex = 51;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(109, 317);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(85, 18);
            firstNameLabel.TabIndex = 52;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(224, 314);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(266, 24);
            this.firstNameTextBox.TabIndex = 53;
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(109, 377);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(66, 18);
            isActiveLabel.TabIndex = 56;
            isActiveLabel.Text = "Is Active:";
            // 
            // isActiveTextBox
            // 
            this.isActiveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "IsActive", true));
            this.isActiveTextBox.Location = new System.Drawing.Point(224, 374);
            this.isActiveTextBox.Name = "isActiveTextBox";
            this.isActiveTextBox.Size = new System.Drawing.Size(266, 24);
            this.isActiveTextBox.TabIndex = 57;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(109, 347);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(84, 18);
            lastNameLabel.TabIndex = 58;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(224, 344);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(266, 24);
            this.lastNameTextBox.TabIndex = 59;
            // 
            // nurseIDLabel
            // 
            nurseIDLabel.AutoSize = true;
            nurseIDLabel.Location = new System.Drawing.Point(109, 220);
            nurseIDLabel.Name = "nurseIDLabel";
            nurseIDLabel.Size = new System.Drawing.Size(70, 18);
            nurseIDLabel.TabIndex = 60;
            nurseIDLabel.Text = "Nurse ID:";
            // 
            // nurseIDTextBox
            // 
            this.nurseIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "NurseID", true));
            this.nurseIDTextBox.Location = new System.Drawing.Point(224, 217);
            this.nurseIDTextBox.Name = "nurseIDTextBox";
            this.nurseIDTextBox.ReadOnly = true;
            this.nurseIDTextBox.Size = new System.Drawing.Size(266, 24);
            this.nurseIDTextBox.TabIndex = 61;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(109, 495);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(79, 18);
            passwordLabel.TabIndex = 62;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(224, 492);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(266, 24);
            this.passwordTextBox.TabIndex = 63;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(510, 350);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 18);
            phoneLabel.TabIndex = 64;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(625, 347);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(266, 24);
            this.phoneTextBox.TabIndex = 65;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(510, 380);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(37, 18);
            sexLabel.TabIndex = 68;
            sexLabel.Text = "Sex:";
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(625, 377);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(266, 24);
            this.sexTextBox.TabIndex = 69;
            // 
            // sSNLabel
            // 
            sSNLabel.AutoSize = true;
            sSNLabel.Location = new System.Drawing.Point(109, 287);
            sSNLabel.Name = "sSNLabel";
            sSNLabel.Size = new System.Drawing.Size(43, 18);
            sSNLabel.TabIndex = 70;
            sSNLabel.Text = "SSN:";
            // 
            // sSNTextBox
            // 
            this.sSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "SSN", true));
            this.sSNTextBox.Location = new System.Drawing.Point(224, 284);
            this.sSNTextBox.Name = "sSNTextBox";
            this.sSNTextBox.ReadOnly = true;
            this.sSNTextBox.Size = new System.Drawing.Size(266, 24);
            this.sSNTextBox.TabIndex = 71;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(510, 290);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(46, 18);
            stateLabel.TabIndex = 72;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(625, 287);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(266, 24);
            this.stateTextBox.TabIndex = 73;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(109, 468);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(81, 18);
            usernameLabel.TabIndex = 74;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(224, 465);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(266, 24);
            this.usernameTextBox.TabIndex = 75;
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(510, 320);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(32, 18);
            zipLabel.TabIndex = 76;
            zipLabel.Text = "Zip:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(625, 317);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(266, 24);
            this.zipTextBox.TabIndex = 77;
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.Location = new System.Drawing.Point(105, 420);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(201, 29);
            this.updateInfoButton.TabIndex = 78;
            this.updateInfoButton.Text = "Update Nurse Information";
            this.updateInfoButton.UseVisualStyleBackColor = true;
            // 
            // updateUserPasswordButton
            // 
            this.updateUserPasswordButton.Location = new System.Drawing.Point(105, 533);
            this.updateUserPasswordButton.Name = "updateUserPasswordButton";
            this.updateUserPasswordButton.Size = new System.Drawing.Size(111, 29);
            this.updateUserPasswordButton.TabIndex = 79;
            this.updateUserPasswordButton.Text = "Update Log In";
            this.updateUserPasswordButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(780, 533);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(111, 29);
            this.clearButton.TabIndex = 80;
            this.clearButton.Text = "Clear Form";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataSource = typeof(ClinicManagementApp.Model.Nurse);
            // 
            // nurseIDDataGridViewTextBoxColumn
            // 
            this.nurseIDDataGridViewTextBoxColumn.DataPropertyName = "NurseID";
            this.nurseIDDataGridViewTextBoxColumn.HeaderText = "Nurse ID";
            this.nurseIDDataGridViewTextBoxColumn.Name = "nurseIDDataGridViewTextBoxColumn";
            this.nurseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            this.isActiveDataGridViewTextBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewTextBoxColumn.HeaderText = "Active Status";
            this.isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
            this.isActiveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UpdateNurseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateUserPasswordButton);
            this.Controls.Add(this.updateInfoButton);
            this.Controls.Add(addressStreetLabel);
            this.Controls.Add(this.addressStreetTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(isActiveLabel);
            this.Controls.Add(this.isActiveTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(nurseIDLabel);
            this.Controls.Add(this.nurseIDTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(sSNLabel);
            this.Controls.Add(this.sSNTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchFirstNameLabel);
            this.Controls.Add(this.searchLastNameLabel);
            this.Controls.Add(this.searchFirstNameTextBox);
            this.Controls.Add(this.searchLastNameTextBox);
            this.Controls.Add(this.nurseDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateNurseUserControl";
            this.Size = new System.Drawing.Size(994, 582);
            this.Load += new System.EventHandler(this.UpdateNurseUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nurseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchFirstNameLabel;
        private System.Windows.Forms.Label searchLastNameLabel;
        private System.Windows.Forms.TextBox searchFirstNameTextBox;
        private System.Windows.Forms.TextBox searchLastNameTextBox;
        private System.Windows.Forms.DataGridView nurseDataGridView;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox addressStreetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox isActiveTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox nurseIDTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox sSNTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.Button updateUserPasswordButton;
        private System.Windows.Forms.Button clearButton;
    }
}
