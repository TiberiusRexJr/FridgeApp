using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FridgeIt.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FridgeIt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddItemPage : ContentPage
    {
        public AddItemPage()
        {
            InitializeComponent();
            BindingContext = new AddItemPageViewModel();
        }
    }
}