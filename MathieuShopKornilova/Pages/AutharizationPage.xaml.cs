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

namespace MathieuShopKornilova.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutharizationPage.xaml
    /// </summary>
    public partial class AutharizationPage : Page
    {
        public AutharizationPage()
        {
            InitializeComponent();
        }
        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text;
            string password = PasswordTb.Text;

            var user = App.db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user != null)
            {
                MessageBox.Show("Coll");
                NavigationService.Navigate(new ServicesPage());
            }
            else
            {
                MessageBox.Show("Wrong");

            }

        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
