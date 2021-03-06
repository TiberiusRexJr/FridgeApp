﻿using FridgeIt.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

    
       public DatabaseUser()
        {
            _databaseUser = new SQLiteConnection(_databaseUserPath);
            _databaseUser.CreateTable<UserModel>();
        }


        public bool Validation(string userEmail,string userPassword)
        {
            var searchResults = _databaseUser.Table<UserModel>().Where(u => u.userEmail == userEmail && u.userPassword == userPassword);
            int rowCount = searchResults.Count();
            if (rowCount == 0)
            {
                return false;
            }
            else
                return true;

        }
        //create
        public bool Create(UserModel user)
        {
            /*
                accept a userModel, look for any instances with same u.userEmail; if none insert user into Table<UserModel>
             */
            var searchResult = _databaseUser.Table<UserModel>().Where(u => u.userEmail == user.userEmail);
            int count = searchResult.Count();

            
            if(count==0)
            {
                var idMax = _databaseUser.Table<UserModel>().OrderByDescending(u => u.userId).FirstOrDefault();
                user.userId = (idMax == null ? 1 : idMax.userId + 1);
                _databaseUser.Insert(user);
                return true;
            }
            else
            {
                return false;
            }

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
