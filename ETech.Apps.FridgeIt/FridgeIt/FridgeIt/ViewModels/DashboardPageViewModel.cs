using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace FridgeIt.ViewModels
{
    class DashboardPageViewModel
    {
        #region Variables 
        private string Token_userEmail = "token_userEmail";
        #endregion

        #region Properties 

        public string LabelUsername
        {
            get {
                var credentials = GetTokenCredentials();
                return credentials.Result.userEmail; 
                }
            set { 
                    
                }
        }
        #endregion
        #region Constructor
            public DashboardPageViewModel()
            { 
                
            }
        #endregion

        #region Functions
        private async Task<(string userEmail, string userPassword)> GetTokenCredentials()
        {
            string userEmail = null;
            string userPassword = null;

            userEmail = await SecureStorage.GetAsync("token_userEmail");
            userPassword = await SecureStorage.GetAsync("token_userPassword");

            return (userEmail, userPassword);
        }
        #endregion

    }
}
