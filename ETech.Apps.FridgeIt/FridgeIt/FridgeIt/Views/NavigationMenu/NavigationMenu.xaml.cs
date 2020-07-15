using FridgeIt.Views.Pages;
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
    public partial class NavigationMenu : MasterDetailPage
    {
        public NavigationMenu()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Type pagetype;

            var item = e.SelectedItem as NavigationMenuMasterMenuItem;
            if (item == null)
                return;
            
            switch(item.Title)
            {
                case "Dashboard":
                    pagetype = typeof(DashboardPage);
                    break;
                case "My Fridge Health":
                    pagetype = typeof(MyFridgeHealth);
                    break;
                case "My Fridge Trends":
                    pagetype = typeof(MyFridgeTrends);
                    break;
                case "Log In":
                    pagetype = typeof(LoginPage);
                    break;
                case "Register":
                    pagetype = typeof(RegisterPage);
                    break;
                default:
                    pagetype = typeof(LoginPage);
                    break;
            }

            var page = (Page)Activator.CreateInstance(pagetype);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }

        private Type PageType(NavigationMenuMasterMenuItem item)
        {

            throw new NotImplementedException();
        }
    }
}