using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// The DAL that interacts with a database for Appointment objects. 
    /// </summary>
    public class AppointmentDAL
    {
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
            
            List<TimeSpan> timeOptions = this.GenerateAppointmentTimeList();
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

    }
}
