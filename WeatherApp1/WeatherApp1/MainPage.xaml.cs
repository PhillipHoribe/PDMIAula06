using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var weather = RestService.For<IWeatherService>("http://api.openweathermap.org");
            var Zipcode = new Entry { Text = "Zipcode" };
            var Adress =  weather.GetAddressAsync(Zipcode);
        }
    }
}
