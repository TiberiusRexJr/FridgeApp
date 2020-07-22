using System;
using System.Collections.Generic;
using System.Text;
using FridgeIt.Persistence;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace FridgeIt.ViewModels
{
    class DashboardPageViewModel
    {
        #region Variables 
        private string Token_userEmail = "token_userEmail";
        private Token _token = new Token();
        #endregion

        #region Properties 

        public string LabelUsername
        {
            get
            {
                string x = null;
                var username = _token.GetTokenCredentials();
                x = username.Result.userEmail;

                return x;
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
