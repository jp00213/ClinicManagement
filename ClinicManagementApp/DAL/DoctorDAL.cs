using ClinicManagementApp.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// The DAL that interacts with a database for Doctor objects. 
    /// </summary>
    public class DoctorDAL
    {

        /// <summary>
        /// Get all the doctors from the database source.
        /// </summary>
        /// <returns>a list of doctor objects</returns>
        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            Doctor doctor = new Doctor();

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "SELECT doctorID, firstName, lastName " +
                "FROM doctor d " +
                "JOIN person pe " +
                "ON d.recordID = pe.recordID ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doctor = new Doctor
                        {
                            DoctorID = (int)(reader)["doctorID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                        };
                        doctors.Add(doctor);
                    }
                }
            }
            return doctors;
        }

        /// <summary>
        /// Gets the doctor for the corresponding appointment ID
        /// </summary>
        /// <param name="appointmentID"></param>
        /// <returns></returns>
        public List<Doctor> GetDoctorAndSpecialtyByAppointmentID(int appointmentID)
        {
            List<Doctor> doctors = new List<Doctor>();
            Doctor doctor = new Doctor();

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "SELECT d.doctorID, e.firstName, e.lastName, ds.specialtyName " +
                "FROM appointment a,  doctor d, person e, doctor_has_specialty ds " +
                "where a.appointmentID = @apptID " +
                "and a.doctorID = d.doctorID " +
                "and d.recordID = e.recordID " +
                "and d.doctorID = ds.doctorID ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            using (selectCommand)
            {
                connection.Open();
                selectCommand.Parameters.AddWithValue("@apptID", appointmentID);
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doctor = new Doctor
                        {
                            DoctorID = (int)(reader)["doctorID"],
                            LastName = (string)(reader)["lastName"],
                            FirstName = (string)(reader)["firstName"],
                            Speciality = (string)(reader)["specialtyName"]
                        };
                        doctors.Add(doctor);
                    }
                }
            }
            return doctors;
        }
    }
}
