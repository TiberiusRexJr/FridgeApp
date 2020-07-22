using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace FridgeIt.Persistence
{
    class UserPreferences
    {
        #region Variables
        private static string Preference_KeepMeLoggedIn= "Preference_KeepMeLoggedIn";

        #endregion

        #region Properties
        public string PreferenceKeepMeLoggedIn
        {
            get { return Preference_KeepMeLoggedIn; }
        }
        #endregion

        #region Constructor
        public UserPreferences()
        {
        }
        #endregion

        #region Functions
        /// <summary>
        /// <para>Returns all User preferences in a <c>Tupple<bool></c></para>
        /// <returns> (bool,bool,bool)</returns>
        /// </summary>
        public (bool KeepMeLoggedIn,bool SomethingElse) GetUserPreferences()
        {
            bool KeepMeLoggedIn = Preferences.Get(PreferenceKeepMeLoggedIn, false);
            bool SomethingElse = false;
            return (KeepMeLoggedIn,SomethingElse);
        }

        #endregion
    }
}
