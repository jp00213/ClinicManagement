using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;

namespace ClinicManagementApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the AppointmentDAL and the View.
    /// </summary>
    public class AppointmentController
    {
        private readonly AppointmentDAL _appointmentDAL;

        /// <summary>
        /// Create an AppointmentController object.
        /// </summary>
        public AppointmentController()
        {
            this._appointmentDAL = new AppointmentDAL();
        }

        /// <summary>
        /// Get all the appointment time optoins from the database source.
        /// </summary>
        /// <returns>a list of options for times of an appointment</returns>
        public List<TimeSpan> GenerateAppointmentTimeList() => _appointmentDAL.GenerateAppointmentTimeList();

        /// <summary>
        /// Get all the appointment time options from the database source by doctor and date.
        /// </summary>
        /// <returns>a list of options for times of an appointment with doctor on specified date</returns>
        /// <param name="date"> date </param>
        /// <param name="doctorID"> id of doctor</param>
        public List<TimeSpan> GetAppointmentTimeOptionsByDateAndDoctor(string date, int doctorID)
        {
            return _appointmentDAL.GetAppointmentTimeOptionsByDateAndDoctor(date, doctorID);
        }

        /// <summary>
        /// Add Appointment to the database source.
        /// </summary>
        /// <returns>AppointmentID of new appointment added</returns>
        /// <param name="appointment"> appointment to Add to database</param>
        public int AddAppointment(Appointment appointment) => this._appointmentDAL.AddAppointment(appointment);

        /// <summary>
        /// Get future Appointment by ID
        /// </summary>
        /// <param name="patientIDIn">patient ID</param>
        /// <returns>future appointment</returns>
        public List<Appointment> GetAppointmentsByID_NowOn(int patientIDIn)
        {
            return _appointmentDAL.GetAppointmentsByID_NowOn(patientIDIn);
        }

        /// <summary>
        /// Get past Appointment by ID
        /// </summary>
        /// <param name="patientIDIn">patient ID</param>
        /// <returns>past appointment</returns>
        public List<Appointment> GetAppointmentsByID_Past(int patientIDIn)
        {
            return _appointmentDAL.GetAppointmentsByID_Past(patientIDIn);
        }

        /// <summary>
        /// Get appointment by ID
        /// </summary>
        /// <param name="appointmentIDIn">appointment ID</param>
        /// <returns>appointment</returns>
        public Appointment GetAppointmentByID(int appointmentIDIn)
        {
            return _appointmentDAL.GetAppointmentByID(appointmentIDIn);
        }

        /// <summary>
        /// Update Appointment details
        /// </summary>
        /// <returns>success message</returns>
        /// <param name="appointment"> appointment object to be updated</param>
        public string UpdateAppointment(Appointment appointment)
        {
            return this._appointmentDAL.UpdateAppointment(appointment);
        }
    }
}
