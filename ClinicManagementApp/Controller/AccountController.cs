﻿using ClinicManagementApp.DAL;
using System;

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

        /// <summary>
        /// Checks if a username is taken in the database already
        /// </summary>
        /// <param name="username"></param>
        /// <returns>True if username is NOT in database</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool IsUsernameUnique(string username)
        {
            return this._accountDAL.IsUsernameUnique(username);
        }
    }
}
