using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;

using Newtonsoft.Json;


namespace FridgeIt.Models
{
    class GroceryItem
    {
        #region Variables
        string description;
        string imageURL;
        string colorCode;
        string category;
        DateTime dateAdded;
        DateTime dateExpired;
        int upc;
        int carbs;
        int protein;
        int fats;

        List<GroceryItem> DashboardList;
        #endregion

        #region Properties
    
        public string Description { get => description; set => description = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
        public string ColorCode { get => colorCode; set => colorCode = value; }
        public string Category { get => category; set => category = value; }
        public DateTime DateAdded { get => dateAdded; set => dateAdded = value; }
        public DateTime DateExpired { get => dateExpired; set => dateExpired = value; }
        public int Upc { get => upc; set => upc = value; }
        public int Carbs { get => carbs; set => carbs = value; }
        public int Protein { get => protein; set => protein = value; }
        public int Fats { get => fats; set => fats = value; }
        internal List<GroceryItem> DashboardList1 { get => DashboardList; set => DashboardList = value; }
        #endregion

        #region Implementations 
        #endregion
        #region Constructor
        public GroceryItem()
        {

        }

     
        #endregion
        #region Functions

        private async void GetProducts(string upc)
        {
            string request = "https://api.edamam.com/api/food-database/v2/parser";
            string _app_id = "42ae87cc";
            string _api_key = "4c06cc5449a6a78761d88069d4d7c744";

            //https://api.edamam.com/api/food-database/v2/parser?upc=078742369440&app_id=42ae87cc&app_key=4c06cc5449a6a78761d88069d4d7c744
            string _completeRequest = $"{request}?upc={upc}&app_id={_app_id}&app_key={_api_key} ";

            HttpClient client = new HttpClient();
            var response= await client.GetStringAsync(_completeRequest);
            var deserizliased=JsonConvert.DeserializeObject(response);
        }
        #endregion
    }
}
