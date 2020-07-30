using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
/*using FridgeIt.Services;*/
using FridgeIt.Views;
using Xamarin.Essentials;

namespace FridgeIt
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            /*DependencyService.Register<MockDataStore>();*/
            MainPage = new NavigationMenu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        
    }
}
