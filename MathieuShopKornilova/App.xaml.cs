using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MathieuShopKornilova.Base;

namespace MathieuShopKornilova
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MatueShopKornilovaEntities1 db = new MatueShopKornilovaEntities1();
        public static MainWindow mainWindow;
    }
}
