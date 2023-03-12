using System;

namespace ClinicManagementApp.Model
{
    /// <summary>
    /// The Appointment model class.
    /// </summary>
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDatetime { get; set; }
        public string Reason { get; set; }

        /// <summary>
        /// Appointment constructor.
        /// </summary>
        public Appointment()
        {

        }

        /// <summary>
        /// Appointment constructor.
        /// </summary>
        /// <param name="appointmentID"> patientID of an appointment</param>
        /// <param name="patientID"> patientID of appointment </param>
        /// <param name="doctorID"> doctorID of appointment</param>
        /// <param name="appointmentDatetime"> date of appointment</param>
        /// <param name="reason"> reason for appointment</param>
        public Appointment(int appointmentID, int patientID, int doctorID, DateTime appointmentDatetime, string reason)
        {
            _ = reason ?? throw new ArgumentNullException("Reason cannot be null");

            this.AppointmentID = appointmentID;
            this.PatientID = patientID;
            this.DoctorID = doctorID;
            this.AppointmentDatetime = appointmentDatetime;
            this.Reason = reason;
        }
    }
}
