﻿using ClinicManagementApp.DAL;
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

        /// <summary>
        /// Verifies if username/password match and user is a nurse
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Boolean IsUsernamePasswordCorrectForNurse(string user, string pass)
        {
            return this._accountDAL.IsUsernamePasswordCorrectForNurse(user, pass);
        }

        /// <summary>
        /// Verifies if username/password match and user is an administrator
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Boolean IsUsernamePasswordCorrectForAdministrator(string user, string pass)
        {
            return this._accountDAL.IsUsernamePasswordCorrectForAdministrator(user, pass);
        }
    }
}
