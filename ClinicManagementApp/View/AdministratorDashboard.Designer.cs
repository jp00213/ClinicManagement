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
            this.addNurseTab = new System.Windows.Forms.TabPage();
            this.viewNurseTab = new System.Windows.Forms.TabPage();
            this.updateNurseTab = new System.Windows.Forms.TabPage();
            this.welcomeUserLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.administratorAddNurse1 = new ClinicManagementApp.UserControls.AdministratorAddNurse();
            this.administratorTabControl.SuspendLayout();
            this.addNurseTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // administratorTabControl
            // 
            this.administratorTabControl.Controls.Add(this.addNurseTab);
            this.administratorTabControl.Controls.Add(this.viewNurseTab);
            this.administratorTabControl.Controls.Add(this.updateNurseTab);
            this.administratorTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.administratorTabControl.Location = new System.Drawing.Point(2, 73);
            this.administratorTabControl.Name = "administratorTabControl";
            this.administratorTabControl.SelectedIndex = 0;
            this.administratorTabControl.Size = new System.Drawing.Size(862, 630);
            this.administratorTabControl.TabIndex = 0;
            // 
            // addNurseTab
            // 
            this.addNurseTab.Controls.Add(this.administratorAddNurse1);
            this.addNurseTab.Location = new System.Drawing.Point(4, 33);
            this.addNurseTab.Name = "addNurseTab";
            this.addNurseTab.Padding = new System.Windows.Forms.Padding(3);
            this.addNurseTab.Size = new System.Drawing.Size(854, 593);
            this.addNurseTab.TabIndex = 0;
            this.addNurseTab.Text = "Add Nurse";
            this.addNurseTab.UseVisualStyleBackColor = true;
            // 
            // viewNurseTab
            // 
            this.viewNurseTab.Location = new System.Drawing.Point(4, 33);
            this.viewNurseTab.Name = "viewNurseTab";
            this.viewNurseTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewNurseTab.Size = new System.Drawing.Size(854, 593);
            this.viewNurseTab.TabIndex = 1;
            this.viewNurseTab.Text = "View Nurse";
            this.viewNurseTab.UseVisualStyleBackColor = true;
            // 
            // updateNurseTab
            // 
            this.updateNurseTab.Location = new System.Drawing.Point(4, 33);
            this.updateNurseTab.Name = "updateNurseTab";
            this.updateNurseTab.Padding = new System.Windows.Forms.Padding(3);
            this.updateNurseTab.Size = new System.Drawing.Size(854, 593);
            this.updateNurseTab.TabIndex = 2;
            this.updateNurseTab.Text = "Update Nurse";
            this.updateNurseTab.UseVisualStyleBackColor = true;
            // 
            // welcomeUserLabel
            // 
            this.welcomeUserLabel.AutoSize = true;
            this.welcomeUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.welcomeUserLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.welcomeUserLabel.Location = new System.Drawing.Point(34, 9);
            this.welcomeUserLabel.Name = "welcomeUserLabel";
            this.welcomeUserLabel.Size = new System.Drawing.Size(115, 29);
            this.welcomeUserLabel.TabIndex = 3;
            this.welcomeUserLabel.Text = "Welcome";
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.logoutLinkLabel.Location = new System.Drawing.Point(744, 14);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(68, 24);
            this.logoutLinkLabel.TabIndex = 4;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkLabel_LinkClicked);
            // 
            // administratorAddNurse1
            // 
            this.administratorAddNurse1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.administratorAddNurse1.Location = new System.Drawing.Point(3, 3);
            this.administratorAddNurse1.Margin = new System.Windows.Forms.Padding(4);
            this.administratorAddNurse1.Name = "administratorAddNurse1";
            this.administratorAddNurse1.Size = new System.Drawing.Size(848, 587);
            this.administratorAddNurse1.TabIndex = 0;
            // 
            // AdministratorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 701);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.welcomeUserLabel);
            this.Controls.Add(this.administratorTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Management Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorDashboard_FormClosed);
            this.administratorTabControl.ResumeLayout(false);
            this.addNurseTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl administratorTabControl;
        private System.Windows.Forms.TabPage addNurseTab;
        private System.Windows.Forms.TabPage viewNurseTab;
        private System.Windows.Forms.Label welcomeUserLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabPage updateNurseTab;
        private UserControls.AdministratorAddNurse administratorAddNurse1;
    }
}