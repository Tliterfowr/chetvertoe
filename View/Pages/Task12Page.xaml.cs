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
    /// Логика взаимодействия для Task12Page.xaml
    /// </summary>
    public partial class Task12Page : Page
    {
        public Task12Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(Tb11.Text);
                double y = double.Parse(Tb12.Text);
                if (x < 0 && y > 0)
                {
                    MessageBox.Show($"Координата ({x},{y}) лежит в первом квадрате", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"Координата ({x},{y}) НЕ лежит в первом квадрате", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
