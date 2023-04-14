using ClinicManagementApp.DAL;

namespace ClinicManagementApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the NurseDAL and the View.
    /// </summary>
    public class AdministratorController
    {
        private readonly AdministratorDAL _administratorDAL;

        /// <summary>
        /// Create a NurseController object.
        /// </summary>
        public AdministratorController()
        {
            this._administratorDAL = new AdministratorDAL();
        }

        /// <summary>
        /// Gets full administrator name by username
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string GetAdministratorName(string user)
        {
            return this._administratorDAL.GetAdministratorName(user);
        }
    }
}
