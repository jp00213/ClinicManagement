using System;
using System.Data.SqlClient;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// The DAL that interacts with a database for Account objects. 
    /// </summary>
    public class AccountDAL
    {
        /// <summary>
        /// Verifies if username/password are valid in the system
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns>True if username and password match</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Boolean IsUsernamePasswordCorrect(string user, string pass)
        {
            if (user == "" || user is null)
            {
                throw new ArgumentOutOfRangeException("user", "Username can't be blank or null");
            }
            if (pass == "" || pass is null)
            {
                throw new ArgumentOutOfRangeException("pass", "Password can't be blank or null");
            }

            Boolean result = false;

            string selectStatement =
                "SELECT Count(*) " +
                "FROM Account " +
                "WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@Username", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Username"].Value = user;
                    selectCommand.Parameters.Add("@Password", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Password"].Value = pass;

                    Int32 count = (Int32)selectCommand.ExecuteScalar();
                    if (count > 0) { result = true; }
                }
            }

            return result;
        }
    }
}
