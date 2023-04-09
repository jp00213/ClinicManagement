using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System.Collections.Generic;

namespace ClinicManagementApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the DoctorDAL and the View.
    /// </summary>
    public class DoctorController
    {
        private readonly DoctorDAL _doctorDAL;

        /// <summary>
        /// Create a DoctorController object.
        /// </summary>
        public DoctorController()
        {
            this._doctorDAL = new DoctorDAL();
        }

        /// <summary>
        /// Get all the doctors from the database source.
        /// </summary>
        /// <returns>a list of doctor objects</returns>
        public List<Doctor> GetDoctors() => _doctorDAL.GetDoctors();

        public List<Doctor> GetDoctorAndSpecialtyByAppointmentID(int appointmentID)
        {
            return _doctorDAL.GetDoctorAndSpecialtyByAppointmentID(appointmentID);
        }
    }
}
