using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Weather_App.API;
using Weather_App.Cities;
using Newtonsoft.Json;

namespace Weather_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string _urlIcon = "http://openweathermap.org/img/w/10d.png";
        public MainWindow()
        {
            InitializeComponent();
            
            MainGrid.Background = new SolidColorBrush(Color.FromArgb(255, 179, 182, 181));
            Title.FontSize = 30;
            Infos.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }

        private async void DisplayInfos(object sender, RoutedEventArgs e)
        {
            Api _api = new Api();
            functions fct = new functions();
            if (Selection.SelectionBoxItem.ToString() == "Alger")
            {
                Alger _alger = new Alger();
                Coordinates coordinatesAlger = _alger.getCoordinates();
                Root algerWeather = await _api.GetWeather(coordinatesAlger);
                Content.Text = $"Current weather in Alger is {algerWeather.current.weather[0].description}.";
                Content.Text += $" The temperature is {Math.Round((algerWeather.current.temp - 273),2)} °C but it feels like {Math.Round((algerWeather.current.feels_like - 273),2)}°C.";
                Content.Text += $" Currently, there are {algerWeather.current.clouds} clouds and sky is {algerWeather.current.weather[0].main}.";
                Content.Text += $"{_urlIcon}";
                
                //Root algerPolution = await _api.GetPolution(coordinatesAlger);
                //Content.Text = $"{algerPolution.list.main.aqi}";

                double tempAlger = Math.Round((algerWeather.current.temp - 273), 2);
                //Temperature.Text = $"Temperature in Alger : {tempAlger} °C";
                //Temperature.Background = fct.backgroundColor(tempAlger);
            }
            else if (Selection.SelectionBoxItem.ToString() == "Berlin")
            {
                Berlin _berlin = new Berlin();
                Coordinates coordinatesBerlin = _berlin.getCoordinates();
                Root berlinWeather = await _api.GetWeather(coordinatesBerlin);
                Content.Text = $"Current weather in Berlin is {berlinWeather.current.weather[0].description}.";
                Content.Text += $" The temperature is {Math.Round((berlinWeather.current.temp - 273),2)} °C but it feels like {Math.Round((berlinWeather.current.feels_like - 273),2)}°C.";
                Content.Text += $" Currently, there are {berlinWeather.current.clouds} clouds and sky is {berlinWeather.current.weather[0].main}.";
                
                //Temperature.Text = $"Temperature in Alger : {Math.Round((berlinWeather.current.temp - 273),2)} °C";
                //Temp.Background = new SolidColorBrush(Colors.CornflowerBlue);
            }
            else if (Selection.SelectionBoxItem.ToString() == "Johannesburg")
            {
                Johannesburg _johannesburg = new Johannesburg();
                Coordinates coordinatesJohannesburg = _johannesburg.getCoordinates();
                Root johannesburgWeather = await _api.GetWeather(coordinatesJohannesburg);
                Content.Text = $"Current weather in Johannesburg is {johannesburgWeather.current.weather[0].description}.";
                Content.Text += $" The temperature is {Math.Round((johannesburgWeather.current.temp - 273),2)} °C but it feels like {Math.Round((johannesburgWeather.current.feels_like - 273),2)}°C.";
                Content.Text += $" Currently, there are {johannesburgWeather.current.clouds} clouds and sky is {johannesburgWeather.current.weather[0].main}.";
            }
            else if (Selection.SelectionBoxItem.ToString() == "London")
            {
                London _london = new London();
                Coordinates coordinatesLondon = _london.getCoordinates();
                Root londonWeather = await _api.GetWeather(coordinatesLondon);
                Content.Text = $"Current weather in London is {londonWeather.current.weather[0].description}.";
                Content.Text += $" The temperature is {Math.Round((londonWeather.current.temp - 273),2)} °C but it feels like {Math.Round((londonWeather.current.feels_like - 273),2)}°C.";
                Content.Text += $" Currently, there are {londonWeather.current.clouds} clouds and sky is {londonWeather.current.weather[0].main}.";
            }
            else if (Selection.SelectionBoxItem.ToString() == "New York")
            {
                New_York _newYork = new New_York();
                Coordinates coordinatesNy = _newYork.getCoordinates();
                Root nyWeather = await _api.GetWeather(coordinatesNy);
                Content.Text = $"Current weather in New York is {nyWeather.current.weather[0].description}.";
                Content.Text += $" The temperature is {Math.Round((nyWeather.current.temp - 273),2)} °C but it feels like {Math.Round((nyWeather.current.feels_like - 273),2)}°C.";
                Content.Text += $" Currently, there are {nyWeather.current.clouds} clouds and sky is {nyWeather.current.weather[0].main}.";
            }
            else if (Selection.SelectionBoxItem.ToString() == "Oslo")
            {
                Oslo _oslo = new Oslo();
                Coordinates coordinatesOslo = _oslo.getCoordinates();
                Root OsloWeather = await _api.GetWeather(coordinatesOslo);
                Content.Text = $"Current weather in Oslo is {OsloWeather.current.weather[0].description}.";
                Content.Text += $" The temperature is {Math.Round((OsloWeather.current.temp - 273),2)} °C but it feels like {Math.Round((OsloWeather.current.feels_like - 273),2)}°C.";
                Content.Text += $" Currently, there are {OsloWeather.current.clouds} clouds and sky is {OsloWeather.current.weather[0].main}.";
            }
            else if (Selection.SelectionBoxItem.ToString() == "Paris")
            {
                Paris _paris = new Paris();
                Coordinates coordinatesParis = _paris.getCoordinates();
                Root parisWeather = await _api.GetWeather(coordinatesParis);
                Content.Text = $"Current weather in Paris is {parisWeather.current.weather[0].description}.";
                Content.Text += $" The temperature is {Math.Round((parisWeather.current.temp - 273),2)} °C but it feels like {Math.Round((parisWeather.current.feels_like - 273),2)}°C.";
                Content.Text += $" Currently, there are {parisWeather.current.clouds} clouds and sky is {parisWeather.current.weather[0].main}.";
            }
            else if (Rio.IsSelected)
            {
                Rio _rio = new Rio();
                Coordinates coordinatesRio = _rio.getCoordinates();
                Root rioWeather = await _api.GetWeather(coordinatesRio);
                Content.Text = $"Current weather in Rio is {rioWeather.current.weather[0].description}.";
                Content.Text += $" The temperature is {Math.Round((rioWeather.current.temp - 273),2)} °C but it feels like {Math.Round((rioWeather.current.feels_like - 273),2)}°C.";
                Content.Text += $" Currently, there are {rioWeather.current.clouds} clouds and sky is {rioWeather.current.weather[0].main}.";
            }
            else if (Selection.Text == "Sydney")
            {
                Sydney _sydney = new Sydney();
                Coordinates coordinatesSydney = _sydney.getCoordinates();
                Root sydneyWeather = await _api.GetWeather(coordinatesSydney);
                Content.Text = $"Current weather in Sydney is {sydneyWeather.current.weather[0].description}.";
                Content.Text += $" The temperature is {Math.Round((sydneyWeather.current.temp - 273),2)} °C but it feels like {Math.Round((sydneyWeather.current.feels_like - 273),2)}°C.";
                Content.Text += $" Currently, there are {sydneyWeather.current.clouds} clouds and sky is {sydneyWeather.current.weather[0].main}.";
            }
            else if (Selection.SelectionBoxItem.ToString() == "Tokyo")
            {
                Tokyo _tokyo = new Tokyo();
                Coordinates coordinatesTokyo = _tokyo.getCoordinates();
                Root tokyoWeather = await _api.GetWeather(coordinatesTokyo);
                Content.Text = $"Current weather in Tokyo is {tokyoWeather.current.weather[0].description}.";
                Content.Text += $" The temperature is {Math.Round((tokyoWeather.current.temp - 273),2)} °C but it feels like {Math.Round((tokyoWeather.current.feels_like - 273),2)}°C.";
                Content.Text += $" Currently, there are {tokyoWeather.current.clouds} clouds and sky is {tokyoWeather.current.weather[0].main}.";
            }
            else
            {
                Content.Text = "You didn't choose a correct city";
            }
        }
    }
}