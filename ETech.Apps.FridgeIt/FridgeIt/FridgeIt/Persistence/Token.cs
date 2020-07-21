using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace FridgeIt.Persistence
{
    /// <summary>
    /// <para>Class that holds <c>Constants</c> for User's sensitive information and functions to access and manipulate said data. One standar location makes it easier to maintain in the future. Edit in one location have to trickle down to wherever esle the data is used</para>
    /// </summary>
    class Token
    {
        #region Variables
        string  token_userPassword;
        string token_userEmail;
        #endregion

        #region Properties
        public string Token_userPassword { get => token_userPassword; set => token_userPassword = value; }
        public string Token_userEmail { get => token_userEmail; set => token_userEmail = value; }
        #endregion

        #region Constructor

        public Token()
        {
            Token_userEmail = "token_userEmail";
            Token_userPassword = "token_userPassword";
        }
        #endregion

        #region Functions
        public async Task<(string userEmail, string userPassword)> GetTokenCredentials()
        {
            string userEmail = null;
            string userPassword = null;

            userEmail = await SecureStorage.GetAsync(Token_userEmail);
            userPassword = await SecureStorage.GetAsync(Token_userPassword);

            return (userEmail, userPassword);
        }
        #endregion
    }
}
