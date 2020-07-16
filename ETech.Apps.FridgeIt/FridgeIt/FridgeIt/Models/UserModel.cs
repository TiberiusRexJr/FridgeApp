using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridgeIt.Models
{
    class UserModel
    {
        [PrimaryKey,AutoIncrement]
        public int userId { get; set; }
        public string userName { get; set; }
        [Unique]
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public string userFirstname { get; set; }
        public string userLastname { get; set; }

        public UserModel()
        {

        }
    }
}
