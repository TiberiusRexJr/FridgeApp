using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using FridgeIt.Database;
using FridgeIt.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FridgeIt.ViewModels
{
    public class LoginPageViewModel : ContentView, INotifyPropertyChanged
    {
        public Command commandButtonLogin;
        public Command commandLabelRegister;
        public string userEmail;
        public string userPassword;
        public string registerLabel = "Register";

        private string labelLoginFailed;
        private bool labelLoginFailedIsVisible;

        public event PropertyChangedEventHandler PropertyChanged;
        public string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }
        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        public string RegisterLabel
        {
            set { registerLabel = value;}
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

        void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool LabelLoginFailedIsVisible 
        {
            get { return labelLoginFailedIsVisible; }
            set { labelLoginFailedIsVisible = value; OnPropertyChanged(); }
        }

        public string LabelLoginFailed { get => labelLoginFailed; set => labelLoginFailed = value; }

        public LoginPageViewModel()
        {
            //call setcommandsFunctions
            //
            CommandButtonLogin = new Command(Button_Login_Clicked);
            LabelLoginFailedIsVisible = false;
            LabelLoginFailed = "Log In Failed, Invalid Email/Password Combination"; 
        }

        private async void Button_Login_Clicked(object sender)
        {
            DatabaseUser db = new DatabaseUser();
            
            bool authorization=db.Validation(UserEmail, UserPassword);
            if(authorization==false)
            {
                LabelLoginFailedIsVisible = true;
            }
            else
            {
                LabelLoginFailedIsVisible = false;
                try
                {
                    await SecureStorage.SetAsync("token", UserPassword);
                }
                catch(Exception ex)
                {
                    //Secure Storage not supported
                }
                App.Current.MainPage = new NavigationMenu("Dashboard");
            }

            
        }

        
    }
}