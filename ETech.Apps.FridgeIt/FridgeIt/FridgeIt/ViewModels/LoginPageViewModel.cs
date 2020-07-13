using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FridgeIt.ViewModels
{
    public class LoginPageViewModel : ContentView, INotifyPropertyChanged
    {
        public Command buttonLoginCommand;
        public string username;
        public string password;
        public Label registerLabel;
        
        

        public string Username
        {
            get => username;
            set
            {
                username = value;
                //propertychanged
            }
        }
        public string Password
        {
            get => password;
            set
            {
                password = value;
                //propertychanged
            }
        }
        
        public LoginPageViewModel()
        {
            InitializeCommandButton();
        }

        private void InitializeCommandButton()
        {
            buttonLoginCommand = new Command(() =>
              {

              });
        }

        private void ButtonLoginClick(object sender, EventArgs e)
        {
            //disable "login" BUTTON
            //pass "UserName" and "Password" PROPERTIES to DATABASE CRUD VALIDATE LOGIN function
            //IF TRUE =>App.Mainpage=new DashBoardPage
            //IF FALSE=> LabelAlert.Text="Invalid Credentials, please try again"

        }
    }
}