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
    /// Логика взаимодействия для Task4Page.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                double a = Convert.ToDouble(Tb1.Text);
                double b = Convert.ToDouble(Tb2.Text);
                double c = Convert.ToDouble(Tb3.Text);
                if (a > b && a > c)
                {
                    if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                    {
                        MessageBox.Show("Треугольник прямоугольный", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Треугольник не прямоугольный", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else if (b > a && b > c)
                {
                    if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
                    {
                        MessageBox.Show("Треугольник прямоугольный", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Треугольник не прямоугольный", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else if (c > a && c > b)
                {
                    if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
                    {
                        MessageBox.Show("Треугольник прямоугольный", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Треугольник не прямоугольный", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Треугольник не прямоугольный", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}
