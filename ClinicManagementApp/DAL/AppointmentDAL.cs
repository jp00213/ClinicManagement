using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// The DAL that interacts with a database for Appointment objects. 
    /// </summary>
    public class AppointmentDAL
    {
        private readonly List<TimeSpan> _fifteenMinuteTimeOptions;

        /// <summary>
        /// Constructor for AppointmentDAL
        /// </summary>
        public AppointmentDAL()
        {
            this._fifteenMinuteTimeOptions = this.GenerateAppointmentTimeList();
        }
        /// <summary>
        /// Get all the appointment time optoins from the database source.
        /// </summary>
        /// <returns>a list of options for times of an appointment</returns>
        public List<TimeSpan> GenerateAppointmentTimeList()
        {
            List<TimeSpan> timeOptions = new List<TimeSpan>();
            TimeSpan time = TimeSpan.Zero;

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "EXEC GenerateAppointmentTimeList";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        time = (TimeSpan)(reader)["TimeOption"];
                        timeOptions.Add(time);
                    }
                }
            }
            return timeOptions;
        }

        /// <summary>
        /// Get all the appointment time options from the database source by doctor and date.
        /// </summary>
        /// <returns>a list of options for times of an appointment with doctor on specified date</returns>
        /// <param name="date"> date </param>
        /// <param name="doctorID"> id of doctor</param>
        public List<TimeSpan> GetAppointmentTimeOptionsByDateAndDoctor(string date, int doctorID)
        {

            List<TimeSpan> timeOptions = new List<TimeSpan>(this._fifteenMinuteTimeOptions);
            TimeSpan time = TimeSpan.Zero;

            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string selectStatement =
                "SELECT CAST(appointmentDatetime AS time) AS TimeOption " + 
                "FROM appointment " +
                "WHERE CAST(appointmentDatetime AS date) = @date " +
                "AND doctorID = @doctorID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@doctorID", System.Data.SqlDbType.Int);
            selectCommand.Parameters["@doctorID"].Value = doctorID;

            selectCommand.Parameters.Add("@date", System.Data.SqlDbType.DateTime);
            selectCommand.Parameters["@date"].Value = date;

            using (selectCommand)
            {
                connection.Open();
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        time = (TimeSpan)(reader)["TimeOption"];
                        timeOptions.Remove(time);
                    }
                }
            }
            return timeOptions;
        }

        /// <summary>
        /// Add Appointment to the database source.
        /// </summary>
        /// <returns>AppointmentID of new appointment added</returns>
        /// <param name="appointment"> appointment to Add to database</param>
        public int AddAppointment(Appointment appointment)
        {
            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string insertStatement =
                "INSERT INTO appointment " +
                "(patientID, doctorID, appointmentDatetime, reason)" +
                "VALUES (@patientID, @doctorID, @appointmentDatetime, @reason)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@patientID", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@patientID"].Value = appointment.PatientID;

            insertCommand.Parameters.Add("@doctorID", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@doctorID"].Value = appointment.DoctorID;

            insertCommand.Parameters.Add("@appointmentDatetime", System.Data.SqlDbType.DateTime);
            insertCommand.Parameters["@appointmentDatetime"].Value = appointment.AppointmentDatetime;

            insertCommand.Parameters.Add("@reason", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@reason"].Value = appointment.Reason;

            using (insertCommand)
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('appointment') FROM appointment";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                using (selectCommand)
                {
                    int appointmentID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return appointmentID;
                }
            }
        }

        /// <summary>
        /// Get future Appointment by ID
        /// </summary>
        /// <param name="patientIDIn">patient ID</param>
        /// <returns>future appointment</returns>
        public List<Appointment> GetAppointmentsByID_NowOn(int patientIDIn)
        {
            List<Appointment> appointments = new List<Appointment>();
            string selectStatement =
                "select d.doctorID, a.appointmentID, a.appointmentDatetime, " +
                "a.reason, e.lastName as doctorLastName, " +
                "CONVERT(VARCHAR, a.appointmentDatetime, 22)  + ' - ' + 'Dr.' + ' ' + e.lastName + ', ' + e.firstName as appointmentSummary, " +
                "e.lastName as appointmentSummary  " +
                "from appointment a, doctor d, person e " +
                "where a.doctorID = d.doctorID " +
                "and d.recordID = e.recordID " +
                "and a.appointmentDatetime >= getDate() " +
                "and a.patientID = @patientID " +
                "order by a.appointmentID ";

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", patientIDIn);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.AppointmentID = (int)(reader)["appointmentID"];
                            appointment.DoctorID = (int)reader["doctorID"];
                            appointment.DoctorName = (string)(reader)["doctorLastName"];
                            appointment.AppointmentDatetime = (DateTime)reader["appointmentDatetime"];
                            appointment.Reason = (string)(reader)["reason"];
                            appointment.AppointmentSummary = (string)(reader)["appointmentSummary"];
                            appointments.Add(appointment);
                        }
                    }
                }
            }
            return appointments;
        }

        /// <summary>
        /// Get past appointment by ID
        /// </summary>
        /// <param name="patientIDIn">patient ID</param>
        /// <returns>past appointment</returns>
        public List<Appointment> GetAppointmentsByID_Past(int patientIDIn)
        {
            List<Appointment> appointments = new List<Appointment>();
            string selectStatement =
                "select d. doctorID, a.appointmentID, a.appointmentDatetime, " +
                "a.reason, e.lastName as doctorLastName, " +
                "CONVERT(VARCHAR, a.appointmentDatetime, 22)  + ' - ' + 'Dr.' + ' ' + e.lastName + ', ' + e.firstName as appointmentSummary " +
                "from appointment a, doctor d, person e " +
                "where a.doctorID = d.doctorID " +
                "and d.recordID = e.recordID " +
                "and a.appointmentDatetime < getDate() " +
                "and a.patientID = @patientID " +
                "order by a.appointmentID desc ";

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", patientIDIn);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.AppointmentID = (int)(reader)["appointmentID"];
                            appointment.DoctorID = (int)reader["doctorID"];
                            appointment.DoctorName = (string)(reader)["doctorLastName"];
                            appointment.AppointmentDatetime = (DateTime)reader["appointmentDatetime"];
                            appointment.Reason = (string)(reader)["reason"];
                            appointment.AppointmentSummary = (string)(reader)["appointmentSummary"];
                            appointments.Add(appointment);
                        }
                    }
                }
            }
            return appointments;
        }

        /// <summary>
        /// Get Appointment by appointment ID
        /// </summary>
        /// <param name="appointmentIDIn">appointment ID</param>
        /// <returns>appointment</returns>
        public Appointment GetAppointmentByID(int appointmentIDIn)
        {
            Appointment appointment = new Appointment();
            string selectStatement =
                "select d.doctorID, a.appointmentID, a.appointmentDatetime,   CONVERT(VARCHAR(5), a.appointmentDatetime, 108) as shortTime  , " +
                "a.reason, e.firstName + ' ' + e.lastName as doctorLastName  " +
                "from appointment a,  doctor d, person e " +
                "where a.doctorID = d.doctorID " +
                "and d.recordID = e.recordID " +
                "and a.appointmentID = @appointmentIDIn " +
                "order by a.appointmentID ";

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@appointmentIDIn", appointmentIDIn);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointment.AppointmentID = (int)(reader)["appointmentID"];
                            appointment.DoctorID = (int)reader["doctorID"];
                            appointment.DoctorName = (string)(reader)["doctorLastName"];
                            appointment.AppointmentDatetime = (DateTime)reader["appointmentDatetime"];
                            appointment.Reason = (string)(reader)["reason"];
                            appointment.TimeInString = (string)(reader)["shortTime"];
                        }
                    }
                }
            }
            return appointment;
        }

        public Appointment GetAppointmentByPatientIDAndDate(int patientIDIn, DateTime appointmentDateIn)
        {
            Appointment appointment = new Appointment();
            string selectStatement =
                "select d.doctorID, a.appointmentID, a.appointmentDatetime,   CONVERT(VARCHAR(10), a.appointmentDatetime, 101) as shortTime  , " +
                "a.reason, e.firstName + ' ' + e.lastName as doctorLastName  " +
                "from appointment a,  doctor d, person e " +
                "where a.doctorID = d.doctorID " +
                "and d.recordID = e.recordID " +
                "and a.patientID = @patientIDIn " +
                "and CONVERT(VARCHAR(10), a.appointmentDatetime, 101) = @appointmentDateIn " +
                "order by a.appointmentDatetime ";
            
            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientIDIn", patientIDIn);
                    selectCommand.Parameters.AddWithValue("@appointmentDateIn", appointmentDateIn);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointment.AppointmentID = (int)(reader)["appointmentID"];
                            appointment.DoctorID = (int)reader["doctorID"];
                            appointment.DoctorName = (string)(reader)["doctorLastName"];
                            appointment.AppointmentDatetime = (DateTime)reader["appointmentDatetime"];
                            appointment.Reason = (string)(reader)["reason"];
                            appointment.TimeInString = (string)(reader)["shortTime"];
                        }
                    }
                }
            }
            return appointment;
        }

        /// <summary>
        /// Update Appointment details
        /// </summary>
        /// <returns>success message</returns>
        /// <param name="appointment"> appointment object to be updated</param>
        public string UpdateAppointment(Appointment appointment)
        {
            SqlConnection connection = ClinicManagementDBConnection.GetConnection();
            string insertStatement =
                "UPDATE appointment " +
                "SET doctorID = @doctorID, appointmentDateTime = @time, " +
                "reason = @reason " +
                "WHERE appointmentID = @appointmentID ";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@doctorID", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@doctorID"].Value = appointment.DoctorID;

            insertCommand.Parameters.Add("@time", System.Data.SqlDbType.DateTime);
            insertCommand.Parameters["@time"].Value = appointment.AppointmentDatetime;

            insertCommand.Parameters.Add("@reason", System.Data.SqlDbType.VarChar);
            insertCommand.Parameters["@reason"].Value = appointment.Reason;

            insertCommand.Parameters.Add("@appointmentID", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@appointmentID"].Value = appointment.AppointmentID;

            using (insertCommand)
            {
                connection.Open();
                int rowsAffected = insertCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return "This appointment has been updated.";
                }
                else
                {
                    return "Appointment was not updated. Please try again.";
                }
            }
        }
    }
}
