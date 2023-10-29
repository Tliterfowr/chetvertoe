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
    /// Логика взаимодействия для Task13Page.xaml
    /// </summary>
    public partial class Task13Page : Page
    {
        public Task13Page()
        {
            InitializeComponent();
        }
        double D = 0;
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            D = 1;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            D = 2;
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(TbX.Text);
                if (D == 1)
                {
                    a = a * 1.06;
                    MessageBox.Show($"Сумма выплаты = {a}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    a = 0;
                }
                else if (D == 2)
                {
                    a = a * 1.08;
                    MessageBox.Show($"Сумма выплаты = {a}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                    a = 0;
                }
            }
            catch 
            {
                MessageBox.Show("Ошибка");
            }   
        }
    }
}
