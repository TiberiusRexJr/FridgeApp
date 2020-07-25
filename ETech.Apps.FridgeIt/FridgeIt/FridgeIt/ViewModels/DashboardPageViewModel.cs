using System;
using System.Collections.Generic;
using System.Text;
using FridgeIt.Persistence;
using System.Threading.Tasks;
using Xamarin.Essentials;
using FridgeIt.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace FridgeIt.ViewModels
{
    class DashboardPageViewModel
    {
        #region Variables 
        private Token _token = new Token();

        public ObservableCollection<GroceryItem> dashboardWatchList=new ObservableCollection<GroceryItem>();

        #endregion

        #region Properties 
        public ObservableCollection<GroceryItem> DashboardWatchList
        {
            get { 
                return dashboardWatchList; 
                }
            
        }
        public string LabelUsername
        {
            get
            {
                string x = null;
                var username = _token.GetTokenCredentials();
                x = username.Result.userEmail;

                return x;
            }       
        }
        #endregion

        #region Constructor
            public DashboardPageViewModel()
            {
            PopulateWatchList();
            }
        #endregion

        #region Functions
        private void PopulateWatchList()
        {
            GroceryItem a = new GroceryItem {Description="Apples"};

            GroceryItem b= new GroceryItem { Description = "Soda"};
            dashboardWatchList.Clear();
            dashboardWatchList.Add(a);
            dashboardWatchList.Add(b);
            


        }
        #endregion

    }
}
