using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Text;
using FridgeIt.Database;
using FridgeIt.Models;
using FridgeIt.Views;
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


        private string token_userPassword;
        private string token_userEmail;

        private string preferences_keepMeLoggedIn = "preferences_keep_me_logged_in";

        private string labelLoginFailed;
        private bool labelLoginFailedIsVisible;

        
        

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
            get => Preferences.Get(preferences_keepMeLoggedIn, false);
            set
            {

                Preferences.Set(preferences_keepMeLoggedIn,value);
                OnPropertyChanged();
            }
        }  
        public string LabelLoginFailed { get => labelLoginFailed; set => labelLoginFailed = value; }
        public string Token_userPassword { get => token_userPassword; set => token_userPassword = value; }
        public string Token_userEmail { get => token_userEmail; set => token_userEmail = value; }
        
        #endregion
        public LoginPageViewModel()
        {
            //call setcommandsFunctions
            //
            CommandButtonLogin = new Command(Button_Login_Clicked);
            LabelLoginFailedIsVisible = false;
            LabelLoginFailed = "Log In Failed, Invalid Email/Password Combination";
            Token_userEmail = "token_userEmail";
            Token_userPassword = "token_userPassword";

            CheckPreferences();
            
        }
        private void CheckPreferences()
        {
            bool keepMeLoggedIn = Preferences.Get(preferences_keepMeLoggedIn, false);
            if(keepMeLoggedIn)
            {
                var credentials = GetTokenCredentials();
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
                await SecureStorage.SetAsync(Token_userEmail, UserEmail);
                await SecureStorage.SetAsync(Token_userPassword, UserPassword);
                LabelLoginFailedIsVisible = false;
                App.Current.MainPage = new NavigationMenu("Dashboard");
            
            }
            else
            {
                LabelLoginFailedIsVisible = true;
            }

            
        }
        

        /// <summary>
        /// <para>
        /// checks <c>Settings obj</c> to see if the <c>"keepMeLoggedIn"</c> property of the <c>SettingsPageViewModel</c> is set to on or off
        /// </para>
        /// </summary>
        /// <returns>bool</returns>
        private bool checkLoginSettings()
        {
            throw new NotImplementedException();
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

        
    }
}