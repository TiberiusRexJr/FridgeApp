using System;
namespace FridgeApp.Models
{
    public class ModelCondiment:ModelFridgeItem
    {
        //wires
        private int _saltContent;
        //constructor
        ModelCondiment(int saltContent)
        {
                this.saltContent=saltContent;
        }

        public int SaltContent
        {
            get{return _saltContent;}
            set{_saltContent=Value;}
        }
        //functions
    }
}