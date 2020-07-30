using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FridgeIt.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace FridgeIt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddItemPage : ContentPage
    {

        public AddItemPage()
        {
            ZXingScannerPage scanPage = new ZXingScannerPage();
            InitializeComponent();
            // BindingContext = new AddItemPageViewModel();
            btnScan.Clicked += async (a, s) => {
                scanPage.OnScanResult += (result) => {
                    scanPage.IsScanning = false;
                    Device.BeginInvokeOnMainThread(async () => {
                        await Navigation.PopModalAsync();
                        await DisplayAlert("Scanned Barcode", result.Text + " , " + result.BarcodeFormat + " ," + result.ResultPoints[0].ToString(), "OK");
                    });
                };
                await Navigation.PushModalAsync(scanPage);
            };

       }
    }
}