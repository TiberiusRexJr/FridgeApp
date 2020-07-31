using System;
using System.Collections.Generic;
using System.Text;

namespace FridgeIt.Services.Models
{
    class ModelGroceryItem
    {
        #region Variables
        #region Nurtrients
        public double ENERC_KCAL { get; set; }
        public double PROCNT { get; set; }
        public double FAT { get; set; }
        public double CHOCDF { get; set; }
        public double FIBTG { get; set; }
        #endregion
        public string label { get; set; }
        public string image { get; set; }
        #endregion



        #region Properties
        #endregion
        #region Implementations
        #endregion
        #region Constructor
        public ModelGroceryItem()
        {

        }

        #endregion
        #region Functions

        #endregion
    }
}
