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

namespace Weather_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            MainGrid.Background = new SolidColorBrush(Color.FromArgb(255, 179, 182, 181));
            Title.FontSize = 30;
            Infos.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }

        private void DisplayInfos(object sender, RoutedEventArgs e)
        {
            if (Selection.SelectionBoxItem.ToString() == "Alger")
            {
                Content.Text = showData("Alger");
            }
            else if (Selection.SelectionBoxItem.ToString() == "Berlin")
            {
                Content.Text = "Berlin";
            }
            else if (Selection.SelectionBoxItem.ToString() == "Johannesburg")
            {
                Content.Text = "test Johannesburg";
            }
            else if (Selection.SelectionBoxItem.ToString() == "London")
            {
                Content.Text = "London";
            }
            else if (Selection.SelectionBoxItem.ToString() == "New York")
            {
                Content.Text = "NewYork";
            }
            else if (Selection.SelectionBoxItem.ToString() == "Oslo")
            {
                Content.Text = "Oslo";
            }
            else if (Selection.SelectionBoxItem.ToString() == "Paris")
            {
                Content.Text = "test Paris";
            }
            else if (Rio.IsSelected)
            {
                Content.Text = "test Rio";
            }
            else if (Selection.Text == "Sydney")
            {
                Content.Text = "test Sydney";
            }
            else if (Selection.SelectionBoxItem.ToString() == "Tokyo")
            {
                Content.Text = "test Tokyo";
            }
            else
            {
                Content.Text = "You didn't choose a correct city";
            }
        }

        private string showData(string city)
        {
            Api _api = new Api();
            if (Selection.SelectedItem.ToString() == "Alger")
            {
                Content.Text = "test alger";
                /*Alger _alger = new Alger();
                Root algerInfos = _api.GetWeather(_alger.getCoordinates());
                return algerInfos.current.sunrise.ToString();*/
            }
            if (city == "Berlin")
            {
                Content.Text = "fzklhfzzf";
            }
            if (city == Johannesburg.Content.ToString())
            {
                Content.Text = "test 2";
            }
            if (city == "London")
            {
                Content.Text = "fzklhfzzf";
            }
            if (city == "NewYork")
            {
                Content.Text = "fzklhfzzf";
            }
            if (city == "Oslo")
            {
                Content.Text = "fzklhfzzf";
            }
            if (city == "Paris")
            {
                Content.Text = "fzklhfzzf";
            }
            if (Rio.IsSelected)
            {
                Content.Text = "test Rio";
            }
            if (Selection.Text == "Sydney")
            {
                Content.Text = "test Sydney";
            }
            if (Selection.SelectedItem.ToString() == "Tokyo")
            {
                Content.Text = "test Tokyo";
            }
            else
            {
                return "you are trying to break the code ...";
            }
            return "";
        }
    }
}