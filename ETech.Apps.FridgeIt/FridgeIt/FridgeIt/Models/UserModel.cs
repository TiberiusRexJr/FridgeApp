using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridgeIt.Models
{
    class UserModel
    {
        [PrimaryKey,AutoIncrement]
        int userid { get; set; }
        string userName { get; set; }
        [Unique]
        string userEmail { get; set; }
        string userPassword { get; set; }
        string userFirstname { get; set; }
        string userLastname { get; set; }

        public UserModel()
        {

        }
    }
}
