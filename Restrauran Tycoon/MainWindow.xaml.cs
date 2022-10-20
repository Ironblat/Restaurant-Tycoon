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
using System.Threading;

namespace Restrauran_Tycoon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Table1_btn_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 100; i != 0; i -= 1)
                Table1_btn.Opacity = i;
            Table1_btn.Visibility = Visibility.Hidden;
            Table1.Visibility = Visibility.Visible;
            for (int i = 0; i != 100; i += 1)
                Table1.Opacity = i;
        }

        private void Table2_btn_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 100; i != 0; i -= 1)
                Table2_btn.Opacity = i;
            Table2_btn.Visibility = Visibility.Hidden;
            Table2.Visibility = Visibility.Visible;
            for (int i = 0; i != 100; i += 1)
                Table2.Opacity = i;
        }

        private void Table3_btn_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 100; i != 0; i -= 10)
                Table3_btn.Opacity = i/100; Thread.Sleep(1000);
            
            Table3_btn.Visibility = Visibility.Hidden;
            Table3.Visibility = Visibility.Visible;
            for (int i = 0; i != 100; i += 1)
                Table3.Opacity = i;
        }


    }
}
