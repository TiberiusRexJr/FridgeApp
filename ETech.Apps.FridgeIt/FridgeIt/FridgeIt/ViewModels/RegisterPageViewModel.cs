using FridgeIt.Models;
using FridgeIt.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FridgeIt.Views;

namespace FridgeIt.ViewModels
{
    public class RegisterPageViewModel : ContentPage
    {
        UserModel user;
        DatabaseUser db;
        public Command CommandButtonRegister { get; set; }
        public string firstname;
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LabelErrorResponse { get; set; }
        public bool LabelErrorResponseIsVisible { get; set; }

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
                App.Current.MainPage.DisplayAlert("SystemAlert", status.ToString(), "Ok");

            }
            else
            {
                App.Current.MainPage.DisplayAlert("SystemAlert", status.ToString(), "Ok");

                App.Current.MainPage.DisplayAlert("SystemAlert", user.userEmail + "Successfully Registered", "Ok");
                App.Current.MainPage = new NavigationPage(new DashboardPage());
            }
        }

        /*async Task CommandButtonClicked()
        {
                await Application.Current.MainPage.DisplayAlert("SystemMessage", Firstname + Lastname + Email + Password, "Ok");

        }*/

    }
}