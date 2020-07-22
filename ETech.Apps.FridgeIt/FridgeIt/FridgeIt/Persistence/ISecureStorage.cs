using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FridgeIt.Persistence
{
    interface ISecureStorage
    {
        void CheckPreferences();

        /// <summary>
        /// <para>
        /// returns  
        /// </para>
        /// </summary>
        /// <returns>(string userEmail,string userPasword) OR (null,null) if <c>SecureStorage</c> token does not exist</returns>
        Task<(string userEmail, string userPassword)> GetTokenCredentials();

    }
}
