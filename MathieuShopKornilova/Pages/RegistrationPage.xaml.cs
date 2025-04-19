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
using MathieuShopKornilova.Base;

namespace MathieuShopKornilova.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text;
            string password = PasswordTb.Text;
            string fullName = NameTb.Text;

            if (RegisterUser(login, password, fullName))
            {
                MessageBox.Show("Регистрация прошла успешно.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new AutharizationPage());
            }
            else
            {
                MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private bool RegisterUser(string login, string password, string fullName)
        {

            var existingUser = App.db.Users.FirstOrDefault(u => u.Login == login);
            if (existingUser != null)
                return false;

            var newUser = new Users
            {
                Login = login,
                Password = password,
                RoleId = 1,
                NameUser = fullName,
            };

            App.db.Users.Add(newUser);
            App.db.SaveChanges();

            return true;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
