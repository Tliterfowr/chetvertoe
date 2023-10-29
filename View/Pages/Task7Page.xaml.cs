using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для Task7Page.xaml
    /// </summary>
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            
            if (PIC(Convert.ToDouble(Tb11.Text), Convert.ToDouble(Tb12.Text), Convert.ToDouble(Tb2.Text)))
                MessageBox.Show("Точка лежит внутри окружности", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("Точка не лежит внутри окружности", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        static bool PIC(double x, double y, double r)
        {
            return (x * x + y * y) <= (r * r);
        }
        
    }
}
