using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace Json1
{
    class Program
    {
        string getUrl = "https://api.edamam.com/api/food-database/v2/parser";
        string getUrl1 = "https://api.edamam.com/api/food-database/v2/parser?upc=078742369440&app_id=42ae87cc&app_key=4c06cc5449a6a78761d88069d4d7c744";
        static void Main(string[] args)
        {
            Json j = new Json();
            j.TestDeserilization();
        }

      
        
    }
}
