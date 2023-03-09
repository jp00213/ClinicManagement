using System.Data.SqlClient;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// The DAL that connects with ClinicManagement database for group cs6232-g1
    /// </summary>
    public class ClinicManagementDBConnection
    {
        /// <summary>
        /// Gets connection to ClinicManagement database
        /// </summary>
        /// <returns>Connection to database</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=cs6232-g1;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
