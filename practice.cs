/* MenuMaster
    sets the Listview with Menuitems

    implementes propertychanged

    double class infile viewModel of Menu

    implements Observalbelist of MenuItems to observe changed
 */
 using System;
 using System.Xamarin;
 using System.Xamrin.Xaml;
namespace FridgeIt.Views
{
    

 public partial class MenuBar:ContentPage
 {
     ListView menuItems;

     public MenuBar()
         {
             IntializeComponents();
             BindingContext=MenuBarViewModel;
             menuItems=MenuItemsListView;
         }
     
 }

 class NavigationMenuMasterViewModel:INotifyPropertyChanged
 {
     public ObservableCollection<NavigationMenuMasterMenuItems> MenuItems{get;set;}

    public NavigationMenuMasterViewModel()
    {
        MenuItems=new ObservableCollection<NavigationMenuMasterMenuItems>new[]
        {
            new MenuItem{id=new Guid(), description="Dashboard"},
            new MenuItems{id=new Guid(), description="UserStatistics"},
            new MenuItems{id=new Guid(), description="MyFridgehealth"},

        }
    }    
 }
 #region INotifyPropertyChanged implementation
 public event PropertyChangedEventHandler PropertyChanged;

 public void OnPropertyChanged([CallerMemberName] string properyName="")
 {
     if(PropertyChanged==null)
     return;
     PropertyChanged.Invoke(this,new PropertyChangedEventArgs(properyName)));
 }
 #endregion
}