using System;
 namespace FridgeApp.Interfaces
{
    public interface IFridgeitem
    {
        //wires
        

        /// <summary>Returns <c>ModelNutriionInfo</c> object for particular intem</summary>
                public List<ModelNutritionalInfo> getFridgeNutrionalVauleSummary();
                 
                /// <summary>Returns <c>ModelStatistics</c> object for particular ModelFridgeItem</summary>
                public List<ModelConsumerStatistics> getFridgeItemStatistics()
                {

                }


        /* 
        --getItemInfo 
        --get


         */

    }
}