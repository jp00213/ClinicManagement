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
        /// Get doctor by id
        /// </summary>
        /// /// <param name="doctorID">id of doctor</param>
        /// <returns>Doctor</returns>
        public Doctor GetDoctorByID(int doctorID)
        {
            Doctor doctor = new Doctor();

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "SELECT d.doctorID, pe.firstName, pe.lastName, s.specialtyName " +
                "FROM doctor d " +
                "JOIN person pe " +
                "ON d.recordID = pe.recordID " +
                "JOIN doctor_has_specialty s " +
                "ON s.doctorID = d.doctorID " +
                "WHERE d.doctorID = @doctorID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@doctorID", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@doctorID"].Value = doctorID;

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
                            Specialty = (string)(reader)["specialtyName"]
                        };
                    }
                }
            }
            return doctor;
        }
    }
}
