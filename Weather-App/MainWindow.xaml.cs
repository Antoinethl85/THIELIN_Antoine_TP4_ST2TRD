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
            if (Selection.Text == "Alger")
            {
                Content.Text = showData("Alger");
            }
            if (Selection.Text == "Berlin")
            {
                Content.Text = "fzklhfzzf";
            }
            if (Selection.SelectedValue.ToString() == Johannesburg.Content.ToString())
            {
                Content.Text = "test 2";
            }
            if (Selection.SelectionBoxItem == London)
            {
                Content.Text = "fzklhfzzf";
            }
            if (Selection.SelectionBoxItem == NewYork)
            {
                Content.Text = "fzklhfzzf";
            }
            if (Selection.SelectionBoxItem == Oslo)
            {
                Content.Text = "fzklhfzzf";
            }
            if (Selection.SelectionBoxItem == Paris)
            {
                Content.Text = "fzklhfzzf";
            }
            if (Selection.SelectionBoxItem == Rio)
            {
                Content.Text = "fzklhfzzf";
            }
            if (Selection.SelectionBoxItem == Sydney)
            {
                Content.Text = "fzklhfzzf";
            }
            if (Selection.SelectionBoxItem == Tokyo)
            {
                Content.Text = "fzklhfzzf";
            }
            else
            {
                Content.Text = "You didn't choose a correct city";
            }
        }

        private string showData(string city)
        {
            Api _api = new Api();
            if (city == "Alger")
            {
                Alger _alger = new Alger();
                Root algerInfos = _api.GetWeather(_alger.getCoordinates());
                return algerInfos.current.sunrise.ToString();
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
            if (city == "Rio")
            {
                Content.Text = "fzklhfzzf";
            }
            if (city == "Sydney")
            {
                Content.Text = "fzklhfzzf";
            }
            if (city == "Tokyo")
            {
                Content.Text = "fzklhfzzf";
            }
            else
            {
                return "you are trying to break the code ...";
            }
            return "";
        }
    }
}