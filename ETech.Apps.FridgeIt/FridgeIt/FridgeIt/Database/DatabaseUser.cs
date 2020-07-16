using FridgeIt.Models;
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

        private object instance = null;

    
       DatabaseUser()
        {
            
        }

        public SQLiteConnection getDatabaseUser()
        {
            var db = new SQLiteConnection(_databaseUserPath);
            db.CreateTable<UserModel>();
            return db;
        }

        public bool Validation(string username,string password)
        {
            throw new NotImplementedException();
        }
        //create
        public bool Create(UserModel user)
        {
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
