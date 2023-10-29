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
    /// Логика взаимодействия для Task14Page.xaml
    /// </summary>
    public partial class Task14Page : Page
    {
        public Task14Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(Tb1.Text);
                double b = Convert.ToDouble(Tb2.Text);
                double S1;
                double S2;
                S1 = a * a - b * b;
                S2 = Math.Pow(a - b, 2);
                if (S1 > S2)
                {
                    MessageBox.Show($"Разность квадратов = {S1}\nМодуаль квадрата разности = {S2}\nРазность квадратов больше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (S1 < S2)
                {
                    MessageBox.Show($"Разность квадратов = {S1}\nМодуаль квадрата разности = {S2}\nМодуль квадрата разности больше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"Разность квадратов = {S1}\nМодуаль квадрата разности = {S2}\nЧисла равны", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch 
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
