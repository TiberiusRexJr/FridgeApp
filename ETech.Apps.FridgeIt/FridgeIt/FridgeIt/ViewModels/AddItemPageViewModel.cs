using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace FridgeIt.ViewModels
{
    class AddItemPageViewModel:ContentView
    {
        #region Variables
         public Command commandScanButtonClicked;
        string labelUPC;
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
            await App.Current.MainPage.DisplayAlert("ok", "ok", "ok");
            //scan object
            var scan = new ZXingScannerPage();
            //push to scan page
            await Navigation.PushAsync(scan);
            //on result event, after image is taken
            //attach += function return
            scan.OnScanResult += (result) =>
              {
                  Device.BeginInvokeOnMainThread(async () =>
                  {
                      await Navigation.PopAsync();
                      LabelUPC = result.Text;
                  });
              };
        }
        
        #endregion
    }
}
