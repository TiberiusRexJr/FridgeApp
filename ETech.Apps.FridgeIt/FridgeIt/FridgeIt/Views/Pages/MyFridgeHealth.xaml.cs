using Microcharts;
using SkiaSharp;
using Microcharts.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry;

namespace FridgeIt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFridgeHealth : ContentPage
    {
        List<Entry> entries;
        public MyFridgeHealth()
        {
            InitializeComponent();
            entries = new List<Entry>
            {
                new Entry(200)
                {
                      Color=SKColor.Parse("#FF1493"),
                      Label="FATS",
                      ValueLabel="200"
                },
                                new Entry(400)
                {
                      Color=SKColor.Parse("#00BFFF"),
                      Label="CARBS",
                      ValueLabel="400"
                },
                                                new Entry(-100)
                {
                      Color=SKColor.Parse("#00CED1"),
                      Label="PROTEIN",
                      ValueLabel="-100"
                }

            };
            MyFridgeHealthChartView.Chart = new RadialGaugeChart { Entries = entries };
        }
    }
}