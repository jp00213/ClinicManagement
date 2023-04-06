using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementApp.DAL
{
    /// <summary>
    /// The DAL that interacts with a database for Account objects. 
    /// </summary>
    public class AccountDAL
    {
        /// <summary>
        /// Hashes a given password using SHA512, returns hashed password as a string
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string HashPassword(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }

        /// <summary>
        /// Verifies if username/password are valid in the system for nurses
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns>True if username and password match, and username is in nurse table</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Boolean IsUsernamePasswordCorrectForNurse(string user, string pass)
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
            Console.WriteLine(this.HashPassword(pass));

            string selectStatement =
                "SELECT Count(*) " +
                "FROM Account " +
                "JOIN Nurse ON Account.Username = Nurse.Username " +
                "WHERE Account.Username = @Username AND Account.Password = @Password " +
                "AND Nurse.activeStatus = 1";

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@Username", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Username"].Value = user;
                    selectCommand.Parameters.Add("@Password", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Password"].Value = this.HashPassword(pass);

                    Int32 count = (Int32)selectCommand.ExecuteScalar();
                    if (count > 0) { result = true; }
                }
            }

            return result;
        }

        /// <summary>
        /// Verifies if username/password are valid in the system for administrators
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns>True if username and password match, and username is in administrator table</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Boolean IsUsernamePasswordCorrectForAdministrator(string user, string pass)
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
                "JOIN Administrator ON Account.Username = Administrator.Username " +
                "WHERE Account.Username = @Username AND Account.Password = @Password";

            using (SqlConnection connection = ClinicManagementDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@Username", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Username"].Value = user;
                    selectCommand.Parameters.Add("@Password", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Password"].Value = this.HashPassword(pass);

                    Int32 count = (Int32)selectCommand.ExecuteScalar();
                    if (count > 0) { result = true; }
                }
            }

            return result;
        }

    }
}
