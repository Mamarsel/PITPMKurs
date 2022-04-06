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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }
     
        private void BorderML(object sender, MouseEventArgs e)
        {

        }

        private void BorderME(object sender, MouseEventArgs e)
        {

        }

        private void AuthBorder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            using(TourFirmBaseEntities1 db = new TourFirmBaseEntities1())
            {
                var client = db.User.FirstOrDefault(x => x.Password == PasswordTextBox.Text && x.Login == LoginTextBox.Text);
                if (client != null && client.Role == "User")
                {
                    ClientMain c = new ClientMain();
                    c.Show();
                    MainWindow.main.Hide();
                }
            }
        }
    }
}
