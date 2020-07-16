using FridgeIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FridgeIt.ViewModels
{
    public class RegisterPageViewModel : ContentPage
    {
        UserModel user;
        public Command CommandButtonRegister { get; set; }
        public string firstname;
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public RegisterPageViewModel()
        {
            user = new UserModel();
            CommandButtonRegister = new Command(CommandButtonClicked);
            Firstname = "Eli";
            Lastname = "Lopez";
            
        }

        private async void CommandButtonClicked(object obj)
        {
            await Application.Current.MainPage.DisplayAlert("SystemMessage", Firstname + Lastname + Email + Password, "Ok");
        }

        /*async Task CommandButtonClicked()
        {
                await DisplayAlert("SystemMessage", Firstname + Lastname + Email + Password, "Ok");

        }*/

    }
}