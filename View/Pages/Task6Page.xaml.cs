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
    /// Логика взаимодействия для Task6Page.xaml
    /// </summary>
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(Tb11.Text);
                double y = Convert.ToDouble(Tb12.Text);
                if (x == 0 & y == 0)
                {
                    MessageBox.Show("Точка находится в начале координат\n1 | 2\n- X -\n3 | 4", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (x == 0 & y > 0)
                {
                    MessageBox.Show("Точка находится между 1 и 2 квадратом\n1 X 2\n- * -\n3 | 4\"", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (x == 0 & y < 0)
                {
                    MessageBox.Show("Точка находится между 3 и 4 квадратом\n1 | 2\n- * -\n3 X 4\"", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (y == 0 & x > 0)
                {
                    MessageBox.Show("Точка находится между 2 и 4 квадратом\n1 | 2\n- * X\n3 | 4\"", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (y == 0 & x < 0)
                {
                    MessageBox.Show("Точка находится между 1 и 3 квадратом\n1 | 2\nX * -\n3 | 4", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (x > 0 & y > 0)
                {
                    MessageBox.Show("Точка находится в 2-ом квадрате\n1 | X\n- * -\n3 | 4", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (x > 0 & y < 0)
                {
                    MessageBox.Show("Точка находится в 4-ом квадрате\n1 | 2\n- * -\n3 | X", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (x < 0 & y > 0)
                {
                    MessageBox.Show("Точка находится в 1-ом квадрате\nX | 2\n- * -\n3 | 4", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (x < 0 & y < 0)
                {
                    MessageBox.Show("Точка находится в 3-ом квадрате\n1 | 2\n- * -\nX | 4", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
