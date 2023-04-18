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
using WpfApp7.DB;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Good good = new Good()
            {
                Description = "Описание",
                Name = "Имя товара",
                Price = 1000,
                Sale = 0.5
            };

            var ef = new ContextDb();
            ef.Add(good);
            ef.SaveChanges();

            data_goods.ItemsSource = new ContextDb().Goods.ToList();
        }
    }
}
