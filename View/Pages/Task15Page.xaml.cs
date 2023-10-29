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

namespace WpfApp3.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task15Page.xaml
    /// </summary>
    public partial class Task15Page : Page
    {
        public Task15Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x0 = Convert.ToDouble(Tb11.Text);
                double y0 = Convert.ToDouble(Tb12.Text);
                double x1 = Convert.ToDouble(Tb21.Text);
                double y1 = Convert.ToDouble(Tb22.Text);
                double ra, rb;
                ra = Math.Sqrt(x0 * x0 + y0 * y0);
                rb = Math.Sqrt(x1 * x1 + y1 * y1);
                if (ra > rb)
                {
                    MessageBox.Show($"Расстояние до точки A = {ra}\nРасстояние до точки B = {rb}\nТочка A дальше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (rb > ra)
                {
                    MessageBox.Show($"Расстояние до точки A = {ra}\nРасстояние до точки B = {rb}\nТочка B дальше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"Расстояние до точки A = {ra}\nРасстояние до точки B = {rb}\nРасстояние до точек одинаковое", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch 
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
