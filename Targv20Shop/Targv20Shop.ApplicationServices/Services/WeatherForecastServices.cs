using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Targv20Shop.Core.Dtos;

namespace Targv20Shop.ApplicationServices.Services
{
    public class WeatherForecastServices
    {
        public async Task<WeatherDto> WeatherResponse()
        {
            string idWeather = "tijodrFSC6VO2AQIyEAHAPl2tAwnbpI5";
            var Location = "asd";
            //connection string
            var url = $"http://dataservice.accuweather.com/forecasts/v1/daily/1day/{Location}?apikey={idWeather}";
            //var client2 = new RestClient($"http://dataservice.accuweather.com/forecasts/v1/daily/1day/127964?apikey=tijodrFSC6VO2AQIyEAHAPl2tAwnbpI5");

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);


            }

                return null;
        }
    }
}
