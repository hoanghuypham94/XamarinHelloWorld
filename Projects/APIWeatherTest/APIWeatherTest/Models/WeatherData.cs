using System;

using Xamarin.Forms;

namespace APIWeatherTest.Models
{
    public class WeatherData : ContentPage
    {
        public WeatherData()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

