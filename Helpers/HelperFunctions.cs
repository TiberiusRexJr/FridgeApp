using System;
namespace FridgeApp
{
    /* class of common functions to give user information about items in thier fridge */

    //wires;

    //functions;
    #region Functions
        public DateTime IsExpired()
        {
            throw new NotImplementedException();
        }
        public List<IFridgeItem> FridgeFoodTypes()
        {
            throw new NotImplementedException();
        }
          /// <summary>Returns <c>ModelNutrionInfo</c> object for particular item</summary>
        //
                public List<ModelNutritionalInfo> getFridgeNutrionalVauleSummary()
                {
                        /*
                        1.query database for all FRIDGEITEMS
                        2.
                        */

                }
                 
                /// <summary>Returns <c>ModelStatistics</c> object for particular ModelFridgeItem</summary>
                public List<ModelConsumerStatistics> getFridgeItemStatistics()
                {
                    //what is fridge statistics
                    /*  
                        1. how many times FridgeItem entered on monthly basis
                        2.                     
                    */
                }

        

    #endregion
}