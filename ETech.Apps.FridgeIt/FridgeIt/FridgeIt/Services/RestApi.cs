using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using FridgeIt.Services.Models;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Xml.Serialization;
using SkiaSharp;

namespace FridgeIt.Services
{
    class RestApi
    {
        #region Variables
        string getUrl = "https://api.edamam.com/api/food-database/v2/parser";
        string getUrl1 = "https://api.edamam.com/api/food-database/v2/parser?upc=078742369440&app_id=42ae87cc&app_key=4c06cc5449a6a78761d88069d4d7c744";
        #endregion
        #region Properties
        #endregion
        #region Implementations
        #endregion
        #region Constructor
        public RestApi()
        {

        }
        #endregion
        #region Functions
        public ModelGroceryItem GetInfoUPC(string upc)
        {
            ModelGroceryItem groceryItem = new ModelGroceryItem();

            HttpClient httpClient = new HttpClient();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
                
                    httpRequestMessage.RequestUri = new Uri(getUrl1);
                    httpRequestMessage.Method = HttpMethod.Get;
                    httpRequestMessage.Headers.Add("Accept", "application/json");

                    Task<HttpResponseMessage> httpResponse = httpClient.SendAsync(httpRequestMessage);

            HttpResponseMessage httpResponseMessage = httpResponse.Result;
                    
                        Console.WriteLine(httpResponseMessage.ToString());

                        //status code
                        HttpStatusCode statusCode = httpResponseMessage.StatusCode;
                        //Console.WriteLine("Status code=>"+statusCode);
                        //Console.WriteLine("Status code=>"+(int)statusCode);

                        //Response Data
                        HttpContent responseContent = httpResponseMessage.Content;
                        Task<string> responseData = responseContent.ReadAsStringAsync();
                        string data = responseData.Result;
                        Console.WriteLine(data);
                        //                        JObject o = JObject.Parse(data);

                        RestResponse restResponse = new RestResponse { StatusCode = statusCode, Content = responseData.Result };

                        var json = JsonConvert.DeserializeObject<Root>(responseData.Result);
                        List<Hint> hints = json.hints;
                        foreach (var x in hints)
                        {
                            groceryItem.CHOCDF = x.food.nutrients.CHOCDF;
                            groceryItem.ENERC_KCAL = x.food.nutrients.ENERC_KCAL;
                            groceryItem.PROCNT = x.food.nutrients.PROCNT;
                            groceryItem.FAT = x.food.nutrients.FAT;
                            groceryItem.FIBTG = x.food.nutrients.FIBTG;
                            groceryItem.label = x.food.label;
                            groceryItem.image = x.food.image;
                        }
            return groceryItem;
        }

        #endregion
    }
}
