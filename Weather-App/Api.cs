using System;
using System.Net.Http;
using System.Threading.Tasks;
using Weather_App.API;
using Newtonsoft.Json;

namespace Weather_App
{
    public class Api
    {
        private HttpClient _client = new HttpClient();
        private static string _url = "https://api.openweathermap.org/data/2.5/onecall";
        private static string _urlpolution = "https://api.openweathermap.org/data/2.5/air_pollution";
        private static string _urlIcon = "http://openweathermap.org/img/w";
        private string _key = "624c4ed18365308ce225acee2b5c2bd2";
        

        public async Task<Root> GetWeather(Coordinates coordinates)
        {
            var json = await RequestGeneral(coordinates, _url);
            Root data = JsonConvert.DeserializeObject<Root>(json);

            await Task.Delay(100);
            return data;
        }
        
        public async Task<Root> GetPolution(Coordinates coordinates)
        {
            var json = await RequestGeneral(coordinates, _urlpolution);
            Root data = JsonConvert.DeserializeObject<Root>(json);

            await Task.Delay(100);
            return data;
        }

        public async Task<Root> getIcon(string icon)
        {
            var json = await RequestIcon(icon);
            Root data = JsonConvert.DeserializeObject<Root>(json);

            await Task.Delay(10000);
            return data;
        }

        public async Task<string> RequestGeneral(Coordinates coordinates, string url)
        {
            url = $"{_urlIcon}?lat={coordinates.lat}&lon={coordinates.lon}&appid={_key}";
            var reponse = await _client.GetAsync(url);

            if (reponse.IsSuccessStatusCode)
            {
                return await reponse.Content.ReadAsStringAsync();
            }

            throw new Exception(await reponse.Content.ReadAsStringAsync());
        }
        
        public async Task<string> RequestIcon(string icon)
        {
            string urlIcn = $"{_urlIcon}/w/{icon}.png";
            var reponse = await _client.GetAsync(urlIcn);

            if (reponse.IsSuccessStatusCode)
            {
                return await reponse.Content.ReadAsStringAsync();
            }

            throw new Exception(await reponse.Content.ReadAsStringAsync());
        }
    }
}