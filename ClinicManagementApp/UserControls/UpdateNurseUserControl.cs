using ClinicManagementApp.Controller;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementApp.UserControls
{
    public partial class UpdateNurseUserControl : UserControl
    {
        private readonly NurseController _nurseController;
        public UpdateNurseUserControl()
        {
            InitializeComponent();
            _nurseController = new NurseController();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            var firstName = this.searchFirstNameTextBox.Text;
            var lastName = this.searchLastNameTextBox.Text;
            List<Nurse> nurseList = _nurseController.GetNurseByName(firstName, lastName);

            this.nurseDataGridView.DataSource = nurseList;

            if (nurseList.Count == 0)
            {
                messageLabel.Text = "No nurses found.";
            }
        }

        private void UpdateNurseUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
