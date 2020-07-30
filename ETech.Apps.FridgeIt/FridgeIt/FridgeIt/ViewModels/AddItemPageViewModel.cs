using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Xamarin.Forms;
using ZXing;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;

namespace FridgeIt.ViewModels
{
    class AddItemPageViewModel : ContentPage
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
            get { return commandScanButtonClicked; }
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
        
        #region Implementations
        #endregion
        #region Constructor
        /*AddItemPageViewModel()
     {
         CommandScanButtonClicked = new Command(Button_Scan_Clicked);
     }*/


        #endregion
        #region Functions

        /* private async void Button_Scan_Clicked(object sender)
         {

             scanPage = new ZXingScannerPage();
             await App.Current.MainPage.DisplayAlert("hello", "hi", "ok");

             await App.Current.MainPage.DisplayAlert("hello", scanPage.ToString(), "ok");
             await App.Current.MainPage.Navigation.PushAsync(scanPage);

             scanPage.OnScanResult += (Result) =>
               {
                   App.Current.MainPage.DisplayAlert("hi from reesult","ok","ok");

                   scanPage.IsScanning = false;

                   Device.BeginInvokeOnMainThread(async() => 
                   {
                       LabelUPC = Result.Text;

                       await App.Current.MainPage.Navigation.PopModalAsync();
                       await App.Current.MainPage.DisplayAlert("SCanned Barcode: ", Result.Text + " " + Result.BarcodeFormat + "," + Result.ResultPoints[0].ToString(), "ok");
                       await App.Current.MainPage.DisplayAlert("SCanned Barcode", LabelUPC, "ok");
                   });
               };

             await Navigation.PushAsync(scanPage);

         }                             */

        #endregion

    } }
