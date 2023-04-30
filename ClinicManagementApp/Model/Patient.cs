using System;

namespace ClinicManagementApp.Model
{
    /// <summary>
    /// The Patient model class.
    /// </summary>
    public class Patient : Person
    {
        public int PatientID { get; set; }
        public DateTime AppointmentDateTime { get; set; }

        /// <summary>
        /// Patient constructor.
        /// </summary>
        public Patient()
        {

        }

        /// <summary>
        /// Patient constructor.
        /// </summary>
        /// <param name="patientID"> patientID of an patient</param>
        public Patient(int patientID)
        {
            this.PatientID = patientID;
        }
    }
}
