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
        public NavigationMenu(string pageTitle)
        {

            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            Page pagetype = PageSwitchBoard(pageTitle);
            Detail = new NavigationPage(pagetype);
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Page pagetype;

            var item = e.SelectedItem as NavigationMenuMasterMenuItem;
            if (item == null)
                return;

             pagetype = PageSwitchBoard(item.Title);
         

            Detail = new NavigationPage(pagetype);
            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;
        }

        private Type PageType(NavigationMenuMasterMenuItem item)
        {

            throw new NotImplementedException();
        }
        

        private Page PageSwitchBoard(string pageTitle)
        {
            Page page = null;
            Type pagetype = null;
            switch (pageTitle)
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
            page = (Page)Activator.CreateInstance(pagetype);
            page.Title = pageTitle;
            return page;
        }
    }
}