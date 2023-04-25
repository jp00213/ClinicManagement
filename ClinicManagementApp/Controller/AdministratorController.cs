using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;

namespace ClinicManagementApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the AdministratorDAL and the View.
    /// </summary>
    public class AdministratorController
    {
        private readonly AdministratorDAL _administratorDAL;

        /// <summary>
        /// Create a AdministratorController object.
        /// </summary>
        public AdministratorController()
        {
            this._administratorDAL = new AdministratorDAL();
        }

        /// <summary>
        /// Returns Person object from administrator username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Person GetAdminstratorByUsername(string username)
        {
            return this._administratorDAL.GetAdminstratorByUsername(username);
        }
    }
}