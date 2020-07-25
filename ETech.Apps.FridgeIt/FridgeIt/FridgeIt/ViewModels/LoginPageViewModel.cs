using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Text;
using FridgeIt.Database;
using FridgeIt.Views;
using FridgeIt.Persistence;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FridgeIt.ViewModels
{
    public class LoginPageViewModel : ContentView, INotifyPropertyChanged
    {
        #region variables
        public Command commandButtonLogin;
        public Command commandLabelRegister;

        public string userEmail;
        public string userPassword;

        private string labelLoginFailed;
        private bool labelLoginFailedIsVisible;

        private Token _token = new Token();
        private UserPreferences _userPreferences = new UserPreferences();

        #endregion

        #region IPropertyChangedImplementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region PropertySetGet
        public string UserEmail
        {
            get { return userEmail; }
            set { 
                userEmail = value;
                OnPropertyChanged(); 
            
                }
        }
        public string UserPassword
        {
            get { return userPassword; }
            set {
                userPassword = value;
                OnPropertyChanged();
                }
        }
   
        public Command CommandButtonLogin
        {
            get { return commandButtonLogin; }
            set { commandButtonLogin = value; }
        }
        public Command CommandLabelRegister
        {
            get { return CommandLabelRegister; }
            set { CommandLabelRegister = value; }
        }

      
        public bool LabelLoginFailedIsVisible 
        {
            get { return labelLoginFailedIsVisible; }
            set { labelLoginFailedIsVisible = value; OnPropertyChanged(); }
        }
        public bool SwitchToggle
        {
            get => Preferences.Get(_userPreferences.PreferenceKeepMeLoggedIn, false);
            set
            {

                Preferences.Set(_userPreferences.PreferenceKeepMeLoggedIn,value);
                OnPropertyChanged();
            }
        }  
        public string LabelLoginFailed { get => labelLoginFailed; set => labelLoginFailed = value; }

        #endregion

        #region Constructor
        public LoginPageViewModel()
        {
            //call setcommandsFunctions
            //
            CommandButtonLogin = new Command(Button_Login_Clicked);
            LabelLoginFailedIsVisible = false;
            LabelLoginFailed = "Log In Failed, Invalid Email/Password Combination";

            CheckPreferences();
            
        }
#endregion

        #region Functions
        private void CheckPreferences()
        {
            bool keepMeLoggedIn = Preferences.Get(_userPreferences.PreferenceKeepMeLoggedIn, false);
            if(keepMeLoggedIn)
            {
                var credentials = _token.GetTokenCredentials();
                UserEmail = credentials.Result.userEmail;
                UserPassword = credentials.Result.userPassword;
            }
            if(!keepMeLoggedIn)
            {

            }
        }

        private async void Button_Login_Clicked(object sender)
        {
            DatabaseUser db = new DatabaseUser();
            
            bool authorization=db.Validation(UserEmail, UserPassword);
            if(authorization)
            {
                

                await SecureStorage.SetAsync(_token.TokenUserEmail, UserEmail);
                await SecureStorage.SetAsync(_token.TokenUserPassword, UserPassword);
                LabelLoginFailedIsVisible = false;
                App.Current.MainPage = new NavigationMenu("Settings");
            
            }
            else
            {
                LabelLoginFailedIsVisible = true;
            }

            
        }
        


        /// <summary>
        /// <para>
        /// returns  
        /// </para>
        /// </summary>
        /// <returns>(string userEmail,string userPasword) OR (null,null) if <c>SecureStorage</c> token does not exist</returns>
        private async Task<(string userEmail,string userPassword)> GetTokenCredentials()
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