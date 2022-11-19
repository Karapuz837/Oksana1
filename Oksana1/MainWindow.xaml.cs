using Oksana1.databaes;
using System;
using System.Collections.Generic;
using System.Data.Common;
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

namespace Oksana1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ToyList.ItemsSource = App.db.Toy.ToList();
        }
        private void SortFiled_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
        public void Refresh()
        {
            IEnumerable<Toy> filter = App.db.Toy;
        }

        private void SearchField_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
