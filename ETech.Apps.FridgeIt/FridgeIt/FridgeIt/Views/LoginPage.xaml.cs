using FridgeIt.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FridgeIt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
            IntializeLabelRegister();


        }

        private void IntializeLabelRegister()
        {
            var tapGesture = new TapGestureRecognizer();
            tapGesture.NumberOfTapsRequired = 1;
            tapGesture.Tapped += (s, e) =>
            {
                App.Current.MainPage = new RegisterPage();
            };
            LabelRegister.GestureRecognizers.Add(tapGesture);
        }


    }
}