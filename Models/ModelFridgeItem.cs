using System;
namespace FridgeApp
{
    public abstract class ModelFridgeItem
    {
        //wires;
        public string productName{get;set;}
        public int UPC{get;set;}
        public DateTime storageDate{get;set;}
        public string category{get;set;}
        //functions;
    }
}