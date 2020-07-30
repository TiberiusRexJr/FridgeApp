using FridgeIt.Models;
using FridgeIt.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FridgeIt.Views;
using FridgeIt.Persistence;
using System.ComponentModel;

namespace FridgeIt.ViewModels
{
    public class RegisterPageViewModel :ContentPage,INotifyPropertyChanged
    {
        UserModel user;
        DatabaseUser db;
        public Command CommandButtonRegister { get; set; }
        public string firstname;
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string labelErrorResponse { get; set; }
        public bool labelErrorResponseIsVisible { get; set; }

        Token token = new Token();

        public event PropertyChangedEventHandler PropertyChanged;

        public string LabelErrorResponse
        {
            get { return labelErrorResponse; }
            set { labelErrorResponse = value; OnPropertyChanged(nameof(LabelErrorResponse)); }
        }
        public bool LabelErrorResponseIsVisible
        {
            get { return labelErrorResponseIsVisible; }
            set { labelErrorResponseIsVisible = value; OnPropertyChanged(nameof(LabelErrorResponseIsVisible)); }
        }
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public RegisterPageViewModel()
        {
            user = new UserModel();
            db = new DatabaseUser();
            CommandButtonRegister = new Command(CommandButtonClicked);
            LabelErrorResponseIsVisible = false;
            LabelErrorResponse = null;
    
        }

        private  void CommandButtonClicked(object obj)
        {
            bool status = false;
            UserModel user = new UserModel();
            if(!string.IsNullOrWhiteSpace(Firstname))
            {
                user.userFirstname = Firstname;
            }
            if(!string.IsNullOrWhiteSpace(Lastname))
            {
                user.userLastname = Lastname;
            }
            if (!string.IsNullOrWhiteSpace(Email))
            {
                user.userEmail = Email;
            }
            if (!string.IsNullOrWhiteSpace(Password))
            {
                user.userPassword= Password;
            }
            status=db.Create(user);
            if(status==false)
            {
                LabelErrorResponse = "Email already in use, please try again";
                
                LabelErrorResponseIsVisible = true;

            }
            else
            {
                token.SetTokenCredentials(user.userEmail, user.userPassword);
                LabelErrorResponseIsVisible = false;
                App.Current.MainPage.DisplayAlert("SystemAlert", user.userEmail + "Successfully Registered", "Ok");
                App.Current.MainPage = new NavigationPage(new NavigationMenu("Dashboard"));
            }
        }

      

    }
}