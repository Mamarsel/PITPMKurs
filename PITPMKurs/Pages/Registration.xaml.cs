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

namespace PITPMKurs
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
           
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            RegBorder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7d4242"));
        }

        private void RegBorder_MouseLeave(object sender, MouseEventArgs e)
        {
            RegBorder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7d5642"));
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.main.MainFrame.Navigate(new Auth());
        }

        private void RegBorder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.main.Hide();
          
            ClientMain m = new ClientMain();
            m.ShowDialog();
        }
    }
}
