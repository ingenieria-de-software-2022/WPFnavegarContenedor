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

namespace WPFnavegarContenedor
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

        private void image1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void buttonPage1_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new Page1());
        }

        private void buttonPage2_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new Page2());
        }

        private void buttonPage3_Click(object sender, RoutedEventArgs e)
        {
           frame1.Navigate(new Page3());
        }

        private void buttonSignature_Click(object sender, RoutedEventArgs e)
        {
           System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }
    }
}
