using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace FridgeIt.ViewModels
{
    class SettingsPageViewModel
    {

        #region Variables
        private string token_userPassword;
        private string token_userEmail;

        private string preferences_keepMeLoggedIn = "preferences_keep_me_logged_in";
        #endregion

        #region Properties
        bool SwitchKeepMeLoggedIn
        {
            set {
                Preferences.Set(preferences_keepMeLoggedIn, value);

                }
            get { 
                 return Preferences.Get(preferences_keepMeLoggedIn, false);

                }
        }
        #endregion
    }
}
