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

namespace S2_Lab10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            DataContext = new MainWindowViewModel();
            InitializeComponent();
        }
        
        private int iterator;
        
        private void Prev_OnClick(object sender, RoutedEventArgs e)
        {
            if (iterator <= 0)
            {
                iterator = DataTable.Items.Count - 1;
            }

            iterator--;
            DataTable.SelectedItem = DataTable.Items.GetItemAt(iterator);
        }
        private void Next_OnClick(object sender, RoutedEventArgs e)
        {
            if (iterator >= DataTable.Items.Count)
            {
                iterator = 0;
            }

            DataTable.SelectedItem = DataTable.Items.GetItemAt(iterator);
            iterator++;
        }
    }
}