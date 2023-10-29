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
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                try
                {
                    double qs = Math.Pow(Convert.ToDouble(Tb1.Text) + Convert.ToDouble(Tb2.Text), 2);
                    double sq = Math.Pow(Convert.ToDouble(Tb1.Text), 2) + Math.Pow(Convert.ToDouble(Tb2.Text), 2);
                    if (qs > sq)
                    {
                        MessageBox.Show($"Квадрат суммы = {qs}\n Сумма квадратов = {sq}\n Квадрат суммы больше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else if (qs == sq)
                    {
                        MessageBox.Show($"Квадрат суммы = {qs}\n Сумма квадратов = {sq}\n Квадрат суммы равен сумме квадратов", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Квадрат суммы = {qs}\n Сумма квадратов = {sq}\n Сумма квадратов больше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch
                {
                    double qs = Math.Pow(Convert.ToDouble(Tb1.Text) + Convert.ToDouble(Tb2.Text), 2);
                    double sq = Math.Pow(Convert.ToDouble(Tb1.Text), 2) + Math.Pow(Convert.ToDouble(Tb2.Text), 2);
                    if (qs > sq)
                    {
                        MessageBox.Show($"Квадрат суммы = {qs}\n Сумма квадратов = {sq}\n Квадрат суммы больше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else if (qs == sq)
                    {
                        MessageBox.Show($"Квадрат суммы = {qs}\n Сумма квадратов = {sq}\n Квадрат суммы равен сумме квадратов", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Введено неверное значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Ошибка");
            }
            }
        }
    }

