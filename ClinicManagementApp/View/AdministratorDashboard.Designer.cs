namespace ClinicManagementApp.View
{
    partial class AdministratorDashboard
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
            this.administratorTabControl = new System.Windows.Forms.TabControl();
            this.addNurseTabPage = new System.Windows.Forms.TabPage();
            this.viewNurseTabPage = new System.Windows.Forms.TabPage();
            this.updateNurseTabPage = new System.Windows.Forms.TabPage();
            this.welcomeUserLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.viewNurseUserControl1 = new ClinicManagementApp.UserControls.ViewNurseUserControl();
            this.updateNurseUserControl1 = new ClinicManagementApp.UserControls.UpdateNurseUserControl();
            this.administratorTabControl.SuspendLayout();
            this.viewNurseTabPage.SuspendLayout();
            this.updateNurseTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // administratorTabControl
            // 
            this.administratorTabControl.Controls.Add(this.addNurseTabPage);
            this.administratorTabControl.Controls.Add(this.viewNurseTabPage);
            this.administratorTabControl.Controls.Add(this.updateNurseTabPage);
            this.administratorTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.administratorTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.administratorTabControl.Location = new System.Drawing.Point(0, 46);
            this.administratorTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.administratorTabControl.Name = "administratorTabControl";
            this.administratorTabControl.SelectedIndex = 0;
            this.administratorTabControl.Size = new System.Drawing.Size(970, 608);
            this.administratorTabControl.TabIndex = 0;
            // 
            // addNurseTabPage
            // 
            this.addNurseTabPage.Location = new System.Drawing.Point(4, 27);
            this.addNurseTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.addNurseTabPage.Name = "addNurseTabPage";
            this.addNurseTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.addNurseTabPage.Size = new System.Drawing.Size(962, 538);
            this.addNurseTabPage.TabIndex = 0;
            this.addNurseTabPage.Text = "Add Nurse";
            this.addNurseTabPage.UseVisualStyleBackColor = true;
            // 
            // viewNurseTabPage
            // 
            this.viewNurseTabPage.Controls.Add(this.viewNurseUserControl1);
            this.viewNurseTabPage.Location = new System.Drawing.Point(4, 27);
            this.viewNurseTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.viewNurseTabPage.Name = "viewNurseTabPage";
            this.viewNurseTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.viewNurseTabPage.Size = new System.Drawing.Size(962, 538);
            this.viewNurseTabPage.TabIndex = 1;
            this.viewNurseTabPage.Text = "View Nurse";
            this.viewNurseTabPage.UseVisualStyleBackColor = true;
            // 
            // updateNurseTabPage
            // 
            this.updateNurseTabPage.Controls.Add(this.updateNurseUserControl1);
            this.updateNurseTabPage.Location = new System.Drawing.Point(4, 27);
            this.updateNurseTabPage.Name = "updateNurseTabPage";
            this.updateNurseTabPage.Size = new System.Drawing.Size(962, 577);
            this.updateNurseTabPage.TabIndex = 2;
            this.updateNurseTabPage.Text = "Update Nurse";
            this.updateNurseTabPage.UseVisualStyleBackColor = true;
            // 
            // welcomeUserLabel
            // 
            this.welcomeUserLabel.AutoSize = true;
            this.welcomeUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.welcomeUserLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.welcomeUserLabel.Location = new System.Drawing.Point(26, 7);
            this.welcomeUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeUserLabel.Name = "welcomeUserLabel";
            this.welcomeUserLabel.Size = new System.Drawing.Size(91, 24);
            this.welcomeUserLabel.TabIndex = 3;
            this.welcomeUserLabel.Text = "Welcome";
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.logoutLinkLabel.Location = new System.Drawing.Point(886, 13);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(54, 18);
            this.logoutLinkLabel.TabIndex = 4;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkLabel_LinkClicked);
            // 
            // viewNurseUserControl1
            // 
            this.viewNurseUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewNurseUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewNurseUserControl1.Location = new System.Drawing.Point(2, 2);
            this.viewNurseUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.viewNurseUserControl1.Name = "viewNurseUserControl1";
            this.viewNurseUserControl1.Size = new System.Drawing.Size(958, 534);
            this.viewNurseUserControl1.TabIndex = 0;
            // 
            // updateNurseUserControl1
            // 
            this.updateNurseUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateNurseUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNurseUserControl1.Location = new System.Drawing.Point(0, 0);
            this.updateNurseUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.updateNurseUserControl1.Name = "updateNurseUserControl1";
            this.updateNurseUserControl1.Size = new System.Drawing.Size(962, 577);
            this.updateNurseUserControl1.TabIndex = 0;
            // 
            // AdministratorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 654);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.welcomeUserLabel);
            this.Controls.Add(this.administratorTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorDashboard_FormClosed);
            this.administratorTabControl.ResumeLayout(false);
            this.viewNurseTabPage.ResumeLayout(false);
            this.updateNurseTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl administratorTabControl;
        private System.Windows.Forms.TabPage addNurseTabPage;
        private System.Windows.Forms.TabPage viewNurseTabPage;
        private System.Windows.Forms.Label welcomeUserLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabPage updateNurseTabPage;
        private UserControls.ViewNurseUserControl viewNurseUserControl1;
        private UserControls.UpdateNurseUserControl updateNurseUserControl1;
    }
}