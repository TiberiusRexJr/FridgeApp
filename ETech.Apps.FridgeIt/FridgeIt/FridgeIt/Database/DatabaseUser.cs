﻿using FridgeIt.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FridgeIt.Database
{
    class DatabaseUser
    {
        public string userDatabaseName = "userDatabase.db3";

        private string _databaseUserPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "userDatabase.db3");
        private SQLiteConnection _databaseUser;

        private object instance = null;

    
       DatabaseUser()
        {
            _databaseUser = new SQLiteConnection(_databaseUserPath);
            _databaseUser.CreateTable<UserModel>();
        }


        public bool Validation(string username,string password)
        {
            /* find a USERMODEL object in DATABASE_USER table where username is==username and password==password
                return true or false
             */
            throw new NotImplementedException();
        }
        //create
        public bool Create(UserModel user)
        {
            /*
                accept a userModel, look for any instances with same u.userId; if none insert user into Table<UserModel>
             */
            var idMax = _databaseUser.Table<UserModel>().OrderByDescending(u => u.userId).FirstOrDefault();

            int id = (idMax == null ? 1 : idMax.userId + 1);

            throw new NotImplementedException();
        }
        //read
        public UserModel Retrieve(string userEmail)
        {
            throw new NotImplementedException();
        }
        //update
        public bool Update(UserModel user)
        {
            throw new NotImplementedException();
        }

        //delete
        public bool Delete(string userEmail)
        {
            throw new NotImplementedException();
        }

    }


}
