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
    /// Логика взаимодействия для Task8Page.xaml
    /// </summary>
    public partial class Task8Page : Page
    {
        public Task8Page()
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
                double p = (a + b + c) / 2;
                double S = (p * (p - a) * (p - b) * (p - c));
                if (S <= 0)
                    MessageBox.Show("Такого треугольника не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                    MessageBox.Show($"Площадь треугольника = {S}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch 
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
