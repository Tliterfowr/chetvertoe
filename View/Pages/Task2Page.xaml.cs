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
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }
        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float zp = Int32.Parse(Tb1.Text);
                float st = Int32.Parse(Tb2.Text);
                if (st < 2)
                {
                    MessageBox.Show($"Надбавка = 0% \nСумма к выплате = {zp}", "Выплатит", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (st >= 2 & st < 5)
                {
                    MessageBox.Show($"Надбавка = 2% \nСумма к выплате = {zp * 1.02}", "Выплатит", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (st >= 5 & st < 10)
                {
                    MessageBox.Show($"Надбавка = 5% \nСумма к выплате = {zp * 1.05}", "Выплатит", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"Надбавка = {4 + st / 5}% \nСумма к выплате = {zp * ((st / 5 + 4) / 100 + 1)}", "Выплатить", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}
