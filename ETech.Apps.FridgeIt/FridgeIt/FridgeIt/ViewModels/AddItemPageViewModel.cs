using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ZXing;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace FridgeIt.ViewModels
{
    class AddItemPageViewModel:ContentView
    {
        #region Variables
         public Command commandScanButtonClicked;
        string labelUPC;
        ZXingScannerPage scanPage;
        #endregion
        #region Properties
        #endregion
        public Command CommandScanButtonClicked
        {
           get{ return  commandScanButtonClicked; }
            set 
            {
                commandScanButtonClicked = value;
            }
        }
        public string LabelUPC
        {
            get { return labelUPC; }
            set { labelUPC = value; }
        }
        public
        #region Implementations
        #endregion
        #region Constructor
           AddItemPageViewModel()
        {
            CommandScanButtonClicked = new Command(Button_Scan_Clicked);
        }
        #endregion
        #region Functions

        private async void Button_Scan_Clicked(object sender)
        {

            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (Result) =>
              {
                  scanPage.IsScanning = false;

                  Device.BeginInvokeOnMainThread(() => 
                  {
                      LabelUPC = Result.Text;

                      Navigation.PopModalAsync();
                      App.Current.MainPage.DisplayAlert("SCanned Barcode", LabelUPC, "ok");
                  });
              };

            await Navigation.PushAsync(scanPage);

        }
        
#endregion
    }
}
