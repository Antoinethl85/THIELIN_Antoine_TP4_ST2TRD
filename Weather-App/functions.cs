using System.Windows.Media;

namespace Weather_App
{
    public class functions
    {
        public Brush backgroundColor(double temp)
        {
            if (temp > 35)
            {
                return new SolidColorBrush(Colors.Red);
            }
            else if (temp < 0)
            {
                return new SolidColorBrush(Colors.DarkCyan);
            }
            else if (temp >= 0 && temp < 15)
            {
                return new SolidColorBrush(Colors.Blue);
            }
            else
            {
                return new SolidColorBrush(Colors.Coral);
            }
        }
    }
}