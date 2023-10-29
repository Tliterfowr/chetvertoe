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
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double F1 = Math.Pow(Convert.ToDouble(TbR.Text), 2);
                double F2 = Math.Pow(Convert.ToDouble(TbS.Text), 2) * Math.PI;
                if (F1 > F2)
                {
                    MessageBox.Show($"Площадь квадрата = {F1}\nПлощадь круга = {F2}\n{F1} > {F2}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (F1 < F2)
                {
                    MessageBox.Show($"Площадь квадрата = {F1}\nПлощадь круга = {F2}\n{F1} < {F2}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show($"Площадь квадрата = {F1}\nПлощадь круга = {F2}\n{F1} = {F2}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}