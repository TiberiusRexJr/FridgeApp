using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using ZXing;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;
/*COMMAND FUCKING DELEGATION NIGGA FUCK YOU KEEP YOUR HANDS UP DAWG*/

namespace FridgeIt.ViewModels
{
    class AddItemPageViewModel : ContentPage
    {
        #region Variables
       /* delegate void mathamatics(int x, int y);
        delegate int math2(int x);
        delegate int math3(int x, int y);
        delegate void math4(int x, int y);*/
        public ICommand AddByUPC;
        string labelUPC;
        ZXingScannerPage scanPage;
        #endregion
        #region Properties
     
        public string LabelUPC
        {
            get { return labelUPC; }
            set { labelUPC = value; }
        }
        #endregion


        #region Implementations
        #endregion
        #region Constructor
        AddItemPageViewModel()
     {
            /*mathamatics math1 = new mathamatics(Add);
            math1 = Subtract;
            math1(1, 32);
            math1 += Add;*/

            /*mathamatics mathamatics = new mathamatics(Add);
            mathamatics += Subtract;
             math2 math2 = x => (x * x);
*/
            /*math3 FunkPatrol = (x, y) => (x * x * y * y);
            FunkPatrol(3, 4);*/

            /*          math4 math4 = (x, y) =>
                      {
                          Console.WriteLine(x + y);
                      };
                      math4(3, 4);
            */
        }


        #endregion
        #region Functions

        public void Add(int x, int y)
        {
            throw new NotImplementedException();
        }
        public void Subtract(int x, int y)
        {
            throw new NotImplementedException();
        }
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
