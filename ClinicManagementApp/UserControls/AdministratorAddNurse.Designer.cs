namespace ClinicManagementApp.UserControls
{
    partial class AdministratorAddNurse
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
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label sSNLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label zipLabel;
            this.addressStreetTextBox = new System.Windows.Forms.TextBox();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.sSNTextBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.nurseInformationLabel = new System.Windows.Forms.Label();
            this.addNurseButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.sexErrorMessageLabel = new System.Windows.Forms.Label();
            this.phoneErrorMessageLabel = new System.Windows.Forms.Label();
            this.DOBErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorMessageLabel = new System.Windows.Forms.Label();
            this.firstNameErrorMessageLabel = new System.Windows.Forms.Label();
            this.addressErrorMessageLabel = new System.Windows.Forms.Label();
            this.cityErrorMessageLabel = new System.Windows.Forms.Label();
            this.stateErrorMessageLabel = new System.Windows.Forms.Label();
            this.zipErrorMessageLabel = new System.Windows.Forms.Label();
            this.ssnErrorMessageLabel = new System.Windows.Forms.Label();
            addressStreetLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            sSNLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressStreetLabel
            // 
            addressStreetLabel.AutoSize = true;
            addressStreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            addressStreetLabel.Location = new System.Drawing.Point(400, 118);
            addressStreetLabel.Name = "addressStreetLabel";
            addressStreetLabel.Size = new System.Drawing.Size(85, 25);
            addressStreetLabel.TabIndex = 1;
            addressStreetLabel.Text = "Address";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cityLabel.Location = new System.Drawing.Point(431, 159);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(46, 25);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "City";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dateOfBirthLabel.Location = new System.Drawing.Point(22, 198);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(123, 25);
            dateOfBirthLabel.TabIndex = 5;
            dateOfBirthLabel.Text = "Date Of Birth";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            firstNameLabel.Location = new System.Drawing.Point(32, 119);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(106, 25);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            lastNameLabel.Location = new System.Drawing.Point(32, 159);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(106, 25);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            phoneLabel.Location = new System.Drawing.Point(69, 237);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(69, 25);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "Phone";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            sexLabel.Location = new System.Drawing.Point(91, 274);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(47, 25);
            sexLabel.TabIndex = 19;
            sexLabel.Text = "Sex";
            // 
            // sSNLabel
            // 
            sSNLabel.AutoSize = true;
            sSNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            sSNLabel.Location = new System.Drawing.Point(434, 277);
            sSNLabel.Name = "sSNLabel";
            sSNLabel.Size = new System.Drawing.Size(54, 25);
            sSNLabel.TabIndex = 21;
            sSNLabel.Text = "SSN";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            stateLabel.Location = new System.Drawing.Point(419, 198);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(58, 25);
            stateLabel.TabIndex = 23;
            stateLabel.Text = "State";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            usernameLabel.Location = new System.Drawing.Point(39, 340);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(102, 25);
            usernameLabel.TabIndex = 25;
            usernameLabel.Text = "Username";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            zipLabel.Location = new System.Drawing.Point(446, 241);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(39, 25);
            zipLabel.TabIndex = 27;
            zipLabel.Text = "Zip";
            // 
            // addressStreetTextBox
            // 
            this.addressStreetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "AddressStreet", true));
            this.addressStreetTextBox.Location = new System.Drawing.Point(491, 118);
            this.addressStreetTextBox.Name = "addressStreetTextBox";
            this.addressStreetTextBox.Size = new System.Drawing.Size(200, 22);
            this.addressStreetTextBox.TabIndex = 2;
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataSource = typeof(ClinicManagementApp.Model.Nurse);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(491, 159);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 22);
            this.cityTextBox.TabIndex = 4;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nurseBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(144, 201);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateOfBirthDateTimePicker.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(144, 122);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(144, 162);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.lastNameTextBox.TabIndex = 12;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(144, 241);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.phoneTextBox.TabIndex = 16;
            // 
            // sexComboBox
            // 
            this.sexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Sex", true));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(144, 278);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(200, 24);
            this.sexComboBox.TabIndex = 20;
            // 
            // sSNTextBox
            // 
            this.sSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "SSN", true));
            this.sSNTextBox.Location = new System.Drawing.Point(491, 277);
            this.sSNTextBox.Name = "sSNTextBox";
            this.sSNTextBox.Size = new System.Drawing.Size(200, 22);
            this.sSNTextBox.TabIndex = 22;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "State", true));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(491, 198);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(200, 24);
            this.stateComboBox.TabIndex = 24;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(144, 343);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 22);
            this.usernameTextBox.TabIndex = 26;
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(491, 241);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(200, 22);
            this.zipTextBox.TabIndex = 28;
            // 
            // nurseInformationLabel
            // 
            this.nurseInformationLabel.AutoSize = true;
            this.nurseInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseInformationLabel.Location = new System.Drawing.Point(241, 44);
            this.nurseInformationLabel.Name = "nurseInformationLabel";
            this.nurseInformationLabel.Size = new System.Drawing.Size(247, 31);
            this.nurseInformationLabel.TabIndex = 29;
            this.nurseInformationLabel.Text = "Nurse Information";
            this.nurseInformationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addNurseButton
            // 
            this.addNurseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNurseButton.Location = new System.Drawing.Point(378, 385);
            this.addNurseButton.Name = "addNurseButton";
            this.addNurseButton.Size = new System.Drawing.Size(125, 35);
            this.addNurseButton.TabIndex = 31;
            this.addNurseButton.Text = "Add Nurse";
            this.addNurseButton.UseVisualStyleBackColor = true;
            this.addNurseButton.Click += new System.EventHandler(this.addNurseButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(187, 385);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(133, 35);
            this.clearButton.TabIndex = 30;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // sexErrorMessageLabel
            // 
            this.sexErrorMessageLabel.AutoSize = true;
            this.sexErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexErrorMessageLabel.Location = new System.Drawing.Point(145, 305);
            this.sexErrorMessageLabel.Name = "sexErrorMessageLabel";
            this.sexErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.sexErrorMessageLabel.TabIndex = 35;
            // 
            // phoneErrorMessageLabel
            // 
            this.phoneErrorMessageLabel.AutoSize = true;
            this.phoneErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorMessageLabel.Location = new System.Drawing.Point(145, 257);
            this.phoneErrorMessageLabel.Name = "phoneErrorMessageLabel";
            this.phoneErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.phoneErrorMessageLabel.TabIndex = 36;
            // 
            // DOBErrorLabel
            // 
            this.DOBErrorLabel.AutoSize = true;
            this.DOBErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBErrorLabel.Location = new System.Drawing.Point(145, 226);
            this.DOBErrorLabel.Name = "DOBErrorLabel";
            this.DOBErrorLabel.Size = new System.Drawing.Size(0, 18);
            this.DOBErrorLabel.TabIndex = 37;
            // 
            // lastNameErrorMessageLabel
            // 
            this.lastNameErrorMessageLabel.AutoSize = true;
            this.lastNameErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameErrorMessageLabel.Location = new System.Drawing.Point(145, 180);
            this.lastNameErrorMessageLabel.Name = "lastNameErrorMessageLabel";
            this.lastNameErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.lastNameErrorMessageLabel.TabIndex = 38;
            // 
            // firstNameErrorMessageLabel
            // 
            this.firstNameErrorMessageLabel.AutoSize = true;
            this.firstNameErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameErrorMessageLabel.Location = new System.Drawing.Point(145, 141);
            this.firstNameErrorMessageLabel.Name = "firstNameErrorMessageLabel";
            this.firstNameErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.firstNameErrorMessageLabel.TabIndex = 39;
            // 
            // addressErrorMessageLabel
            // 
            this.addressErrorMessageLabel.AutoSize = true;
            this.addressErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorMessageLabel.Location = new System.Drawing.Point(488, 143);
            this.addressErrorMessageLabel.Name = "addressErrorMessageLabel";
            this.addressErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.addressErrorMessageLabel.TabIndex = 40;
            // 
            // cityErrorMessageLabel
            // 
            this.cityErrorMessageLabel.AutoSize = true;
            this.cityErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityErrorMessageLabel.Location = new System.Drawing.Point(488, 180);
            this.cityErrorMessageLabel.Name = "cityErrorMessageLabel";
            this.cityErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.cityErrorMessageLabel.TabIndex = 41;
            // 
            // stateErrorMessageLabel
            // 
            this.stateErrorMessageLabel.AutoSize = true;
            this.stateErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateErrorMessageLabel.Location = new System.Drawing.Point(488, 220);
            this.stateErrorMessageLabel.Name = "stateErrorMessageLabel";
            this.stateErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.stateErrorMessageLabel.TabIndex = 42;
            // 
            // zipErrorMessageLabel
            // 
            this.zipErrorMessageLabel.AutoSize = true;
            this.zipErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipErrorMessageLabel.Location = new System.Drawing.Point(488, 259);
            this.zipErrorMessageLabel.Name = "zipErrorMessageLabel";
            this.zipErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.zipErrorMessageLabel.TabIndex = 43;
            // 
            // ssnErrorMessageLabel
            // 
            this.ssnErrorMessageLabel.AutoSize = true;
            this.ssnErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnErrorMessageLabel.Location = new System.Drawing.Point(488, 305);
            this.ssnErrorMessageLabel.Name = "ssnErrorMessageLabel";
            this.ssnErrorMessageLabel.Size = new System.Drawing.Size(0, 18);
            this.ssnErrorMessageLabel.TabIndex = 44;
            // 
            // AdministratorAddNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ssnErrorMessageLabel);
            this.Controls.Add(this.zipErrorMessageLabel);
            this.Controls.Add(this.stateErrorMessageLabel);
            this.Controls.Add(this.cityErrorMessageLabel);
            this.Controls.Add(this.addressErrorMessageLabel);
            this.Controls.Add(this.firstNameErrorMessageLabel);
            this.Controls.Add(this.lastNameErrorMessageLabel);
            this.Controls.Add(this.DOBErrorLabel);
            this.Controls.Add(this.phoneErrorMessageLabel);
            this.Controls.Add(this.sexErrorMessageLabel);
            this.Controls.Add(this.addNurseButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.nurseInformationLabel);
            this.Controls.Add(addressStreetLabel);
            this.Controls.Add(this.addressStreetTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(sSNLabel);
            this.Controls.Add(this.sSNTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.zipTextBox);
            this.Name = "AdministratorAddNurse";
            this.Size = new System.Drawing.Size(740, 499);
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource nurseBindingSource;
        private System.Windows.Forms.TextBox addressStreetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.TextBox sSNTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label nurseInformationLabel;
        private System.Windows.Forms.Button addNurseButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label sexErrorMessageLabel;
        private System.Windows.Forms.Label phoneErrorMessageLabel;
        private System.Windows.Forms.Label DOBErrorLabel;
        private System.Windows.Forms.Label lastNameErrorMessageLabel;
        private System.Windows.Forms.Label firstNameErrorMessageLabel;
        private System.Windows.Forms.Label addressErrorMessageLabel;
        private System.Windows.Forms.Label cityErrorMessageLabel;
        private System.Windows.Forms.Label stateErrorMessageLabel;
        private System.Windows.Forms.Label zipErrorMessageLabel;
        private System.Windows.Forms.Label ssnErrorMessageLabel;
    }
}
