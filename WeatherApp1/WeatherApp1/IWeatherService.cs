using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherApp1
{
    public interface IWeatherService
    {[Get("/ data / 2.5 / weather ? zip ={zipcode},us&appid=8c6f71216ac45ae6b1357e647379cfc1&units=imperial")]
        Task<Weather> GetAddressAsync(string zipcode);
        Task GetAddressAsync(Entry zipcode);
    }
}
