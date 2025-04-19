using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MathieuShopKornilova.Base;

namespace MathieuShopKornilova.Components
{
    /// <summary>
    /// Логика взаимодействия для ServiceControl.xaml
    /// </summary>
    public partial class ServiceControl : UserControl
    {
        public Services Services { get; set; }
        public ServiceControl(Services services)
        {
            InitializeComponent();
            DataContext = services;
            Services = services;
            
        }
    }
}
