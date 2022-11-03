using Newtonsoft.Json;
using System;

namespace crudOPXAM
{
    public class EthPrediction
    {

       
        public long Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameid")]
        public string Nameid { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("price_usd")]
        public string PriceUsd { get; set; }

        [JsonProperty("percent_change_24h")]
        public string PercentChange24H { get; set; }

        [JsonProperty("percent_change_1h")]
        public string PercentChange1H { get; set; }

        [JsonProperty("percent_change_7d")]
        public string PercentChange7D { get; set; }

        [JsonProperty("market_cap_usd")]
        public string MarketCapUsd { get; set; }

        [JsonProperty("volume24")]
        public string Volume24 { get; set; }

        [JsonProperty("volume24_native")]
        public string Volume24Native { get; set; }

        [JsonProperty("csupply")]
        public string Csupply { get; set; }

        [JsonProperty("price_btc")]
        public string PriceBtc { get; set; }

  
        public long Tsupply { get; set; }

        [JsonProperty("msupply")]
        public string Msupply { get; set; }
    

    }
}