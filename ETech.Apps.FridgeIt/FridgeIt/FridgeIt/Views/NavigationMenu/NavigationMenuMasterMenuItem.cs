using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FridgeIt.Views
{

    public class NavigationMenuMasterMenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
        public NavigationMenuMasterMenuItem()
        {
            TargetType = typeof(NavigationMenuMasterMenuItem);
        }
        public NavigationMenuMasterMenuItem(int id,string title,ContentPage a)
        {
            TargetType = typeof(NavigationMenuMasterMenuItem);
        }

    }
}