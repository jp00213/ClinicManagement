using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementApp.Model
{
    /// <summary>
    /// The appointment with Dr name model class
    /// </summary>
    public class AppointmentWithDrName : Appointment
    {
        public string DoctorName { get; set; }

        public string AppointmentSummary { get; set; }

        public string TimeInString { get; set; }
    }
}
