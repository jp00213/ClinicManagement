using ClinicManagementApp.DAL;
using ClinicManagementApp.Model;
using System;
using System.Collections.Generic;

namespace ClinicManagementApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the AccountDAL and the View.
    /// </summary>
    public class AccountController
    {
        private readonly AccountDAL _accountDAL;

        /// <summary>
        /// Create a AccountController object.
        /// </summary>
        public AccountController()
        {
            this._accountDAL = new AccountDAL();
        }

        public Boolean IsUsernamePasswordCorrect(string user, string pass)
        {
            return this._accountDAL.IsUsernamePasswordCorrect(user, pass);
        }
    }
}
