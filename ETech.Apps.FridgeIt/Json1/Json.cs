using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace Json1
{

    public class Json
    {
        string getUrl = "https://api.edamam.com/api/food-database/v2/parser";
        string getUrl1 = "https://api.edamam.com/api/food-database/v2/parser?upc=078742369440&app_id=42ae87cc&app_key=4c06cc5449a6a78761d88069d4d7c744";

        public void TestDeserilization()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage())
                {
                    httpRequestMessage.RequestUri = new Uri(getUrl1);
                    httpRequestMessage.Method = HttpMethod.Get;
                    httpRequestMessage.Headers.Add("Accept", "application/json");

                    Task<HttpResponseMessage> httpResponse = httpClient.SendAsync(httpRequestMessage);

                    using(HttpResponseMessage httpResponseMessage=httpResponse.Result)
                    {
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
                        JObject o = JObject.Parse(data);

                        RestResponse restResponse = new RestResponse {StatusCode=statusCode,Content=responseData.Result};
                        var json= JsonConvert.DeserializeObject<Root>(responseData.Result);
                        //List<Root> parasedResult = JsonConvert.DeserializeObject<List<Root>>(responseData.Result);//
                        //Console.WriteLine(parasedResult[0].ToString());//

                        

                    }
                }
            }
        }
    }
}
