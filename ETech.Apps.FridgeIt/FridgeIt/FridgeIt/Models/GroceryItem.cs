using System;
using System.Collections.Generic;
using System.Text;


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
        #endregion
    }
}
