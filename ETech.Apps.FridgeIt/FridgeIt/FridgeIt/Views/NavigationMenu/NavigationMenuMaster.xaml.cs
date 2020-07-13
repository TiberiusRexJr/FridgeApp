﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FridgeIt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationMenuMaster : ContentPage
    {
        public ListView ListView;

        public NavigationMenuMaster()
        {
            InitializeComponent();

            BindingContext = new NavigationMenuMasterViewModel();
            ListView = MenuItemsListView;
        }

        class NavigationMenuMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<NavigationMenuMasterMenuItem> MenuItems { get; set; }

            public NavigationMenuMasterViewModel()
            {
                MenuItems = new ObservableCollection<NavigationMenuMasterMenuItem>(new[]
                {
                    new NavigationMenuMasterMenuItem { Id = 0, Title = "Dashboard" },
                    new NavigationMenuMasterMenuItem { Id = 1, Title = "Register" },
                    new NavigationMenuMasterMenuItem { Id = 2, Title = "Login" },
                    new NavigationMenuMasterMenuItem { Id = 3, Title = "Page 4" },
                    new NavigationMenuMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}