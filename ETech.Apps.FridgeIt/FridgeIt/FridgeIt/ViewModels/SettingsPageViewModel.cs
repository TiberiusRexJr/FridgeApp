using FridgeIt.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Essentials;

namespace FridgeIt.ViewModels
{
    class SettingsPageViewModel:INotifyPropertyChanged
    {

        #region Variables
        private string token_userPassword;
        private string token_userEmail;

        private Token _userToken = new Token();
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
        public string LabelUsername
        {
            get 
            {
                var credentials = _userToken.GetTokenCredentials();

                return credentials.Result.userEmail;
            }
        }
        #endregion

        #region ImplementationINotifyProperyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string PropertyName=null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(PropertyName));
        }
        #endregion
        #region Constructor
        public SettingsPageViewModel()
        {

        }
        #endregion

        #region Functions
        #endregion
    }
}
