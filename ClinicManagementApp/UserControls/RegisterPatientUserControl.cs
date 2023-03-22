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
    public partial class RegisterPatientUserControl : UserControl
    {
        public RegisterPatientUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears all textboxes on page
        /// </summary>
        public void ResetInputFields()
        {
            lastNameTextBox.Clear();
            firstNameTextBox.Clear();
            dateOfBirthTextBox.Clear();
            phoneTextBox.Clear();
            addressTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipTextBox.Clear();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetInputFields();
        }
    }
}
