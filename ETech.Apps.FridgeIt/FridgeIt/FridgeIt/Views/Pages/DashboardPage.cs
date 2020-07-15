using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FridgeIt.Views
{
    public class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Dashboard" }
                }
            };
        }
    }
}