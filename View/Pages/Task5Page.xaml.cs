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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                double a, b, c;

                a = Convert.ToDouble(Tb1.Text);

                b = Convert.ToDouble(Tb2.Text);
                c = Convert.ToDouble(Tb3.Text); 

                if (a > 0)
                {
                    a = Math.Pow(a, 2);
                }
                if (b > 0)
                {
                    b = Math.Pow(b, 2);
                }
                if (c > 0)
                {
                    c = Math.Pow(c, 2);
                }
                MessageBox.Show($"a = {a}\nb = {b}\nc = {c}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
                catch 
                {
                MessageBox.Show($"Ошибка");
            }
        }
    }
}
