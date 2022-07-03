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

            Api _api = new Api();
            Alger _alger = new Alger();
            Console.WriteLine(_alger);
        }

        private void displayInfos(object sender, RoutedEventArgs e)
        {
            Content.Text = "AACAJAIIJFAPIFAIPFAAPFIPIAF";
            if (Selection.SelectionBoxItem == Alger)
            {
                Content.Text = "fzklhfzzf";
            }
            if (Selection.SelectionBoxItem == Berlin)
            {
                Content.Text = "fzklhfzzf";
            }
            if (Selection.SelectionBoxItem == Johannesburg)
            {
                Content.Text = "fzklhfzzf";
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
    }
}