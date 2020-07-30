SQLite-net-pcl
using SQLite;
using FridgeIt.Views;

namespace FridgeIt.Database
{
    
    public class DatabaseUser()
    {
        private SQLiteConnection _userDatabase;
    private string _userDatabasePath=Path.Combine(System.Enviroment.GetFolderPath(System.Enviroment.SpecialFolder.Personal),"UserDatabe.db3"));

            public DatabaseUser()
            {
                _userDatabase=new SQLiteConnection(_userDatabasePath);
                

            }

            public bool Validate(string userEmail,string userPassword)
            {
                var dataset=_userDatabase<UserModel>.Where(u =>u.userEmail==userEmail && u.userPassword==userPassword);

                if(dataset==null)
                {
                    return false;
                }
                else
                {
                    return true
                }
            }

            public bool Create(UserModel user)
            {
                var idCount=_userDatabase.Table<UserModel>().OrderByDescending(u =>u.UserId).FirstOrDefault();
                int id=(idCount?null:1 idCount.UserId+1);

                user.userId=id;
                _userDatabase.Insert(user);
                
            }
    }
    
}