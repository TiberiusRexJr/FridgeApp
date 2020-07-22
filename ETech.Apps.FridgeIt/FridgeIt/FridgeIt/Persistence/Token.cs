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
        static string Token_userEmail = "Token_userEmail";
        static string Token_userPassword = "Token_userPassword";
        #endregion

        #region Properties
        public string TokenUserEmail
            {
                get{
                return Token_userEmail;
                    }
            }
        public string TokenUserPassword
        {
            get
            {
                return Token_userPassword;
            }
        }
            
            
        #endregion

        #region Constructor

        public Token()
        {

        }
        #endregion

        #region Functions
        public async Task<(string userEmail, string userPassword)> GetTokenCredentials()
        {
            string userEmail = null;
            string userPassword = null;

            userEmail = await SecureStorage.GetAsync(TokenUserEmail
                );
            userPassword = await SecureStorage.GetAsync(TokenUserPassword);

            return (userEmail, userPassword);
        }
        #endregion
    }
}
