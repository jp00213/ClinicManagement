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

        /// <summary>
        /// Create a NurseController object.
        /// </summary>
        public NurseController()
        {
            this._nurseDAL = new NurseDAL();
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
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Nurse StoreNurse(string user)
        {
            Nurse currentNurse = this._nurseDAL.GetNurseByUsername(user);
            return currentNurse;

        }
    }
}
