using System;
using System.Drawing;

namespace FridgeApp
{
    public abstract class ModelFridgeItem
    {
        //wires;
        Database database=new Database();
        public string productName{get;set;}
        public int UPC{get;set;}
        public DateTime placementDate{get;set;}
        public DateTime expirationDate{get;set;}        
        public string category{get;set;}
        public Color expirationStatus= Color.FromName("Green");
        //functions;
        public List<ModelFridgeItem> IsExpiredDummy()
        {
            //class databasePROPERTY
            DateTime days=(expirationDate-placementDate).Days;
            this.expirationStatus=determineFlagColor(days);

        }

        private Color determineFlagColor(DateTime days)
        {
            Color flagColor=null;
            switch(days)
            {
                //green
                case (days>=3): flagColor=Color.FromName("Green");
                case (days<=2 && days>0): flagColor=Color.FromName("Yellow");
                case (days==0): flagColor=Color.FromName("Red");
                default:
                flagColor=Color.FromName("Red");
                //yellow
                //red
            }
            return flagColor;
        }
    }
}