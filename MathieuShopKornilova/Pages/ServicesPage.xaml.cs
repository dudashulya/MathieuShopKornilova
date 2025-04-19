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
using MathieuShopKornilova.Components;

namespace MathieuShopKornilova.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServicesPage.xaml
    /// </summary>
    public partial class ServicesPage : Page
    {
        public List<ServiceControl> serviceControls{ get; private set; } = new List<ServiceControl>();
        public ServicesPage()
        {
            InitializeComponent();
            SortCb.ItemsSource = new List<Collection>() { new Collection() { NameCollection = "Все" } }.Concat(App.db.Collection.ToList()).ToList();
            SortCb.SelectedIndex = 0;
            Refresh();
        }
        public void Refresh()
        {
            MyPanel.Children.Clear();
            IEnumerable<Services> ser = App.db.Services;
            if (SerchTb.Text != "")
                ser = ser.Where(x => x.ServiceName.ToLower().Contains(SerchTb.Text.ToLower()));

            if (SortCb.SelectedIndex != -1 && SortCb.SelectedIndex != 0)
                ser = ser.Where(x => x.CollectionId == (SortCb.SelectedItem as Collection).ID);

            foreach (var a in ser)
            {
                var pro = new ServiceControl(a);
                MyPanel.Children.Add(pro);


            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AutharizationPage());    
        }

        private void SerchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();  
        }

        private void SortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
