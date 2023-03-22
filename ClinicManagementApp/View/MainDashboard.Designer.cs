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
            this.updatePatientInformationUserControl1 = new ClinicManagementApp.UserControls.UpdatePatientInformationUserControl();
            this.ViewTabPage = new System.Windows.Forms.TabPage();
            this.CreateTabPage = new System.Windows.Forms.TabPage();
            this.createAppointmentUserControl1 = new ClinicManagementApp.UserControls.CreateAppointmentUserControl();
            this.DocumentTabPage = new System.Windows.Forms.TabPage();
            this.LabsTabPage = new System.Windows.Forms.TabPage();
            this.registerPatientUserControl1 = new ClinicManagementApp.UserControls.RegisterPatientUserControl();
            this.nurseTabControl.SuspendLayout();
            this.registerTabPage.SuspendLayout();
            this.UpdateTabPage.SuspendLayout();
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
            this.registerTabPage.Controls.Add(this.registerPatientUserControl1);
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
            this.UpdateTabPage.Controls.Add(this.updatePatientInformationUserControl1);
            this.UpdateTabPage.Location = new System.Drawing.Point(4, 27);
            this.UpdateTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateTabPage.Name = "UpdateTabPage";
            this.UpdateTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.UpdateTabPage.Size = new System.Drawing.Size(854, 599);
            this.UpdateTabPage.TabIndex = 1;
            this.UpdateTabPage.Text = "Update Patient";
            this.UpdateTabPage.UseVisualStyleBackColor = true;
            // 
            // updatePatientInformationUserControl1
            // 
            this.updatePatientInformationUserControl1.Location = new System.Drawing.Point(28, 7);
            this.updatePatientInformationUserControl1.Name = "updatePatientInformationUserControl1";
            this.updatePatientInformationUserControl1.Size = new System.Drawing.Size(798, 585);
            this.updatePatientInformationUserControl1.TabIndex = 0;
            // 
            // ViewTabPage
            // 
            this.ViewTabPage.Location = new System.Drawing.Point(4, 27);
            this.ViewTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.ViewTabPage.Name = "ViewTabPage";
            this.ViewTabPage.Size = new System.Drawing.Size(854, 599);
            this.ViewTabPage.TabIndex = 2;
            this.ViewTabPage.Text = "View Patient";
            this.ViewTabPage.UseVisualStyleBackColor = true;
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
            // registerPatientUserControl1
            // 
            this.registerPatientUserControl1.Location = new System.Drawing.Point(8, 66);
            this.registerPatientUserControl1.Name = "registerPatientUserControl1";
            this.registerPatientUserControl1.Size = new System.Drawing.Size(804, 499);
            this.registerPatientUserControl1.TabIndex = 0;
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
            this.registerTabPage.ResumeLayout(false);
            this.UpdateTabPage.ResumeLayout(false);
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
        private UserControls.UpdatePatientInformationUserControl updatePatientInformationUserControl1;
        private UserControls.RegisterPatientUserControl registerPatientUserControl1;
    }
}

