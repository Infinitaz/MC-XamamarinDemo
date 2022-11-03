using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace crudOPXAM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Task task = GetJsonAsync();
        }

        public static string url = "https://api.coinlore.net/api/ticker/?id=80";

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var httpClient = new HttpClient();
            // get string from server
            var resultJson = await httpClient.GetStringAsync("https://api.coinlore.net/api/ticker/?id=80");

            var resultsETH = JsonConvert.DeserializeObject<EthPrediction[]>(resultJson);

            forecasts.ItemsSource = resultsETH;
            

        
        }
  


        /* 
        public async Task GetJsonAsync()
        {
            var uri = new Uri("https://api.coinlore.net/api/ticker/?id=80");
            HttpClient httpClient = new HttpClient(); // method for calling to http
            Debug.WriteLine("Waiting for response");

            var response = await httpClient.GetAsync(uri); // wait until the method has connected

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                string json = content.ToString();
                var jsonObject = JObject.Parse(json);

                var id = jsonObject["id"];
                var symbol = jsonObject["symbol"];
                var price_usd = jsonObject["price_usd"];
                Debug.WriteLine(id);

            }

        }
        */

    }
}
