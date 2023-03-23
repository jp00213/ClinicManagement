namespace ClinicManagementApp
{
    partial class MainDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nurseTabControl = new System.Windows.Forms.TabControl();
            this.registerTabPage = new System.Windows.Forms.TabPage();
            this.UpdateTabPage = new System.Windows.Forms.TabPage();
            this.ViewTabPage = new System.Windows.Forms.TabPage();
            this.bottomPanelHoldMultipleUserControl = new System.Windows.Forms.Panel();
            this.patientAppointmentListUserControl1 = new ClinicManagementApp.UserControls.PatientAppointmentListUserControl();
            this.patientVisitListUserControl1 = new ClinicManagementApp.UserControls.PatientVisitListUserControl();
            this.patientDisplayInfoUserControl1 = new ClinicManagementApp.UserControls.PatientDisplayInfoUserControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientVisitButton = new System.Windows.Forms.Button();
            this.patientAppointmentButton = new System.Windows.Forms.Button();
            this.patientInfoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currentPatientIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPatientUserControl1 = new ClinicManagementApp.UserControls.SearchPatientUserControl();
            this.CreateTabPage = new System.Windows.Forms.TabPage();
            this.createAppointmentUserControl1 = new ClinicManagementApp.UserControls.CreateAppointmentUserControl();
            this.DocumentTabPage = new System.Windows.Forms.TabPage();
            this.LabsTabPage = new System.Windows.Forms.TabPage();
            this.nurseTabControl.SuspendLayout();
            this.ViewTabPage.SuspendLayout();
            this.bottomPanelHoldMultipleUserControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.CreateTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // nurseTabControl
            // 
            this.nurseTabControl.Controls.Add(this.registerTabPage);
            this.nurseTabControl.Controls.Add(this.UpdateTabPage);
            this.nurseTabControl.Controls.Add(this.ViewTabPage);
            this.nurseTabControl.Controls.Add(this.CreateTabPage);
            this.nurseTabControl.Controls.Add(this.DocumentTabPage);
            this.nurseTabControl.Controls.Add(this.LabsTabPage);
            this.nurseTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nurseTabControl.Location = new System.Drawing.Point(0, 71);
            this.nurseTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.nurseTabControl.Name = "nurseTabControl";
            this.nurseTabControl.SelectedIndex = 0;
            this.nurseTabControl.Size = new System.Drawing.Size(862, 630);
            this.nurseTabControl.TabIndex = 0;
            // 
            // registerTabPage
            // 
            this.registerTabPage.Location = new System.Drawing.Point(4, 27);
            this.registerTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.registerTabPage.Name = "registerTabPage";
            this.registerTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.registerTabPage.Size = new System.Drawing.Size(854, 599);
            this.registerTabPage.TabIndex = 0;
            this.registerTabPage.Text = "Register Patient";
            this.registerTabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateTabPage
            // 
            this.UpdateTabPage.Location = new System.Drawing.Point(4, 27);
            this.UpdateTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateTabPage.Name = "UpdateTabPage";
            this.UpdateTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.UpdateTabPage.Size = new System.Drawing.Size(854, 599);
            this.UpdateTabPage.TabIndex = 1;
            this.UpdateTabPage.Text = "Update Patient";
            this.UpdateTabPage.UseVisualStyleBackColor = true;
            // 
            // ViewTabPage
            // 
            this.ViewTabPage.Controls.Add(this.bottomPanelHoldMultipleUserControl);
            this.ViewTabPage.Controls.Add(this.tableLayoutPanel1);
            this.ViewTabPage.Location = new System.Drawing.Point(4, 27);
            this.ViewTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.ViewTabPage.Name = "ViewTabPage";
            this.ViewTabPage.Size = new System.Drawing.Size(854, 599);
            this.ViewTabPage.TabIndex = 2;
            this.ViewTabPage.Text = "View Patient";
            this.ViewTabPage.UseVisualStyleBackColor = true;
            // 
            // bottomPanelHoldMultipleUserControl
            // 
            this.bottomPanelHoldMultipleUserControl.Controls.Add(this.patientAppointmentListUserControl1);
            this.bottomPanelHoldMultipleUserControl.Controls.Add(this.patientVisitListUserControl1);
            this.bottomPanelHoldMultipleUserControl.Controls.Add(this.patientDisplayInfoUserControl1);
            this.bottomPanelHoldMultipleUserControl.Location = new System.Drawing.Point(8, 286);
            this.bottomPanelHoldMultipleUserControl.Name = "bottomPanelHoldMultipleUserControl";
            this.bottomPanelHoldMultipleUserControl.Size = new System.Drawing.Size(838, 305);
            this.bottomPanelHoldMultipleUserControl.TabIndex = 1;
            // 
            // patientAppointmentListUserControl1
            // 
            this.patientAppointmentListUserControl1.Location = new System.Drawing.Point(3, 4);
            this.patientAppointmentListUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.patientAppointmentListUserControl1.Name = "patientAppointmentListUserControl1";
            this.patientAppointmentListUserControl1.Size = new System.Drawing.Size(803, 299);
            this.patientAppointmentListUserControl1.TabIndex = 2;
            // 
            // patientVisitListUserControl1
            // 
            this.patientVisitListUserControl1.Location = new System.Drawing.Point(3, 4);
            this.patientVisitListUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.patientVisitListUserControl1.Name = "patientVisitListUserControl1";
            this.patientVisitListUserControl1.Size = new System.Drawing.Size(832, 297);
            this.patientVisitListUserControl1.TabIndex = 2;
            // 
            // patientDisplayInfoUserControl1
            // 
            this.patientDisplayInfoUserControl1.Location = new System.Drawing.Point(1, 4);
            this.patientDisplayInfoUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.patientDisplayInfoUserControl1.Name = "patientDisplayInfoUserControl1";
            this.patientDisplayInfoUserControl1.Size = new System.Drawing.Size(817, 297);
            this.patientDisplayInfoUserControl1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.47292F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.527076F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchPatientUserControl1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.95219F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.04781F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 276);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.patientVisitButton);
            this.panel1.Controls.Add(this.patientAppointmentButton);
            this.panel1.Controls.Add(this.patientInfoButton);
            this.panel1.Location = new System.Drawing.Point(3, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 31);
            this.panel1.TabIndex = 0;
            // 
            // patientVisitButton
            // 
            this.patientVisitButton.BackColor = System.Drawing.Color.Gainsboro;
            this.patientVisitButton.Location = new System.Drawing.Point(485, 0);
            this.patientVisitButton.Name = "patientVisitButton";
            this.patientVisitButton.Size = new System.Drawing.Size(167, 32);
            this.patientVisitButton.TabIndex = 5;
            this.patientVisitButton.Text = "Patient Visit";
            this.patientVisitButton.UseVisualStyleBackColor = false;
            this.patientVisitButton.Click += new System.EventHandler(this.patientVisitButton_Click);
            // 
            // patientAppointmentButton
            // 
            this.patientAppointmentButton.BackColor = System.Drawing.Color.Gainsboro;
            this.patientAppointmentButton.Location = new System.Drawing.Point(312, 0);
            this.patientAppointmentButton.Name = "patientAppointmentButton";
            this.patientAppointmentButton.Size = new System.Drawing.Size(167, 32);
            this.patientAppointmentButton.TabIndex = 4;
            this.patientAppointmentButton.Text = "Patient Appointment";
            this.patientAppointmentButton.UseVisualStyleBackColor = false;
            this.patientAppointmentButton.Click += new System.EventHandler(this.patientAppointmentButton_Click);
            // 
            // patientInfoButton
            // 
            this.patientInfoButton.BackColor = System.Drawing.Color.Gainsboro;
            this.patientInfoButton.Location = new System.Drawing.Point(139, 0);
            this.patientInfoButton.Name = "patientInfoButton";
            this.patientInfoButton.Size = new System.Drawing.Size(167, 32);
            this.patientInfoButton.TabIndex = 3;
            this.patientInfoButton.Text = "Patient Info";
            this.patientInfoButton.UseVisualStyleBackColor = false;
            this.patientInfoButton.Click += new System.EventHandler(this.patientInfoButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.currentPatientIDLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 21);
            this.panel2.TabIndex = 1;
            // 
            // currentPatientIDLabel
            // 
            this.currentPatientIDLabel.AutoSize = true;
            this.currentPatientIDLabel.Location = new System.Drawing.Point(149, 4);
            this.currentPatientIDLabel.Name = "currentPatientIDLabel";
            this.currentPatientIDLabel.Size = new System.Drawing.Size(16, 18);
            this.currentPatientIDLabel.TabIndex = 1;
            this.currentPatientIDLabel.Text = "0";
            this.currentPatientIDLabel.TextChanged += new System.EventHandler(this.currentPatientIDLabel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Patient #:";
            // 
            // searchPatientUserControl1
            // 
            this.searchPatientUserControl1.Location = new System.Drawing.Point(2, 29);
            this.searchPatientUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.searchPatientUserControl1.Name = "searchPatientUserControl1";
            this.searchPatientUserControl1.Size = new System.Drawing.Size(826, 202);
            this.searchPatientUserControl1.TabIndex = 2;
            this.searchPatientUserControl1.PatientNumberChanged += new System.EventHandler(this.searchPatientUserControl1_PatientNumberChanged);
            // 
            // CreateTabPage
            // 
            this.CreateTabPage.Controls.Add(this.createAppointmentUserControl1);
            this.CreateTabPage.Location = new System.Drawing.Point(4, 27);
            this.CreateTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.CreateTabPage.Name = "CreateTabPage";
            this.CreateTabPage.Size = new System.Drawing.Size(854, 599);
            this.CreateTabPage.TabIndex = 3;
            this.CreateTabPage.Text = "Create Appointment";
            this.CreateTabPage.UseVisualStyleBackColor = true;
            // 
            // createAppointmentUserControl1
            // 
            this.createAppointmentUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAppointmentUserControl1.Location = new System.Drawing.Point(14, 4);
            this.createAppointmentUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.createAppointmentUserControl1.Name = "createAppointmentUserControl1";
            this.createAppointmentUserControl1.Size = new System.Drawing.Size(836, 586);
            this.createAppointmentUserControl1.TabIndex = 0;
            // 
            // DocumentTabPage
            // 
            this.DocumentTabPage.Location = new System.Drawing.Point(4, 27);
            this.DocumentTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentTabPage.Name = "DocumentTabPage";
            this.DocumentTabPage.Size = new System.Drawing.Size(854, 599);
            this.DocumentTabPage.TabIndex = 4;
            this.DocumentTabPage.Text = "Document Visit";
            this.DocumentTabPage.UseVisualStyleBackColor = true;
            // 
            // LabsTabPage
            // 
            this.LabsTabPage.Location = new System.Drawing.Point(4, 27);
            this.LabsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.LabsTabPage.Name = "LabsTabPage";
            this.LabsTabPage.Size = new System.Drawing.Size(854, 599);
            this.LabsTabPage.TabIndex = 5;
            this.LabsTabPage.Text = "Labs";
            this.LabsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 701);
            this.Controls.Add(this.nurseTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management Application";
            this.nurseTabControl.ResumeLayout(false);
            this.ViewTabPage.ResumeLayout(false);
            this.bottomPanelHoldMultipleUserControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CreateTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl nurseTabControl;
        private System.Windows.Forms.TabPage UpdateTabPage;
        private System.Windows.Forms.TabPage ViewTabPage;
        private System.Windows.Forms.TabPage CreateTabPage;
        private System.Windows.Forms.TabPage DocumentTabPage;
        private System.Windows.Forms.TabPage LabsTabPage;
        private System.Windows.Forms.TabPage registerTabPage;
        private UserControls.CreateAppointmentUserControl createAppointmentUserControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button patientVisitButton;
        private System.Windows.Forms.Button patientAppointmentButton;
        private System.Windows.Forms.Button patientInfoButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label currentPatientIDLabel;
        private System.Windows.Forms.Label label1;
        private UserControls.SearchPatientUserControl searchPatientUserControl1;
        private System.Windows.Forms.Panel bottomPanelHoldMultipleUserControl;
        private UserControls.PatientAppointmentListUserControl patientAppointmentListUserControl1;
        private UserControls.PatientVisitListUserControl patientVisitListUserControl1;
        private UserControls.PatientDisplayInfoUserControl patientDisplayInfoUserControl1;
    }
}

