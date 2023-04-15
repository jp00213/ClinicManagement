using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;

namespace ClinicManagementApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the NurseDAL and the View.
    /// </summary>
    public class NurseController
    {
        private readonly NurseDAL _nurseDAL;
        private static CurrentUser currentUser;
        
        /// <summary>
        /// Create a NurseController object.
        /// </summary>
        public NurseController()
        {
            this._nurseDAL = new NurseDAL();
            currentUser = new CurrentUser();
        }

        /// <summary>
        /// Gets full nurse name by username
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string GetNurseName(string user)
        {
            return this._nurseDAL.GetNurseName(user);
        }

        /// <summary>
        /// Get nurse by id
        /// </summary>
        /// /// <param name="nurseID">id of nurse</param>
        /// <returns>Nurse</returns>
        public Nurse GetNurseByID(int nurseID) => _nurseDAL.GetNurseByID(nurseID);

        /// <summary>
        /// Gets nurse by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Nurse GetNurseByUsername(string username)
        {
            return this._nurseDAL.GetNurseByUsername(username);
        }

        /// <summary>
        /// Gets the current user's username
        /// </summary>
        /// <returns></returns>
        public static string GetUsername()
        {
            return currentUser.userName;
        }

        /// <summary>
        /// Sets the current user's username
        /// </summary>
        /// <param name="username"></param>
        public static void SetUsername(string username)
        {
            currentUser.userName = username;
        }
    }
}
