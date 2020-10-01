using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp1
{
    public class Weather
    {
        [JsonProperty("name")]
        public string Title { get; set; }
        [JsonProperty("temp")]
        public string Temperature { get; set; }
        [JsonProperty("wind")]
        public string Wind { get; set; }
        [JsonProperty("humidity")]
        public string Humidity { get; set; }
        [JsonProperty("visibility")]
        public string Visibility { get; set; }
        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }
        [JsonProperty("sunset")]
        public string Sunset { get; set; }
    }
}
