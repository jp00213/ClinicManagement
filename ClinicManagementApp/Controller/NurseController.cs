using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;

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

    }
}
