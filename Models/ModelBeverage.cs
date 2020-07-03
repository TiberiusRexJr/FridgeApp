using System;
namespace FridgeApp.Models
{
    class ModelBeverage:ModelFridgeItem
    {
        //wires
        public float _volume;
        //constructor
        ModelBeverage(float volume)
        {
            this._volume=volume;
        }
        //fucntions
        public float Volume
        {
            get{return _volume;}
            set{_volume=value;}
        }
    }

}