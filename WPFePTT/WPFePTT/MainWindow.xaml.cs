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

namespace WPFePTT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Main1.Content = new Image1();
            
        }



       

        


       

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            
            Main1.Content = new Image1();
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            Main1.Content = new Image2();
        }
        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            Main1.Content = new Image3();
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            Main1.Content = new Image4();
        }

        private void RadioButton_Click_4(object sender, RoutedEventArgs e)
        {
            Main1.Content = new Image5();
        }

        private void RadioButton_Click_5(object sender, RoutedEventArgs e)
        {
            Main1.Content = new Image6();
        }

        private void RadioButton_Click_6(object sender, RoutedEventArgs e)
        {
            Main1.Content = new Image7();
        }

        private void RadioButton_Click_7(object sender, RoutedEventArgs e)
        {
            Main1.Content = new Image8();
        }

        private void RadioButton_Click_8(object sender, RoutedEventArgs e)
        {
            Main1.Content = new Image10();
        }


        private void ListViewItem_MouseMove(object sender, MouseEventArgs e)
        {
            Main1.Content = false;
            Main.Content = new Elektronik();
        }

        private void ListViewItem_MouseMove_1(object sender, MouseEventArgs e)
        {
            Main1.Content = false;
            Main.Content = new Anne();

        }

        private void ListViewItem_MouseMove_2(object sender, MouseEventArgs e)
        {
            Main1.Content = false;
            Main.Content = new Moda();
        }

        private void ListViewItem_MouseMove_3(object sender, MouseEventArgs e)
        {
            Main1.Content = false;
            Main.Content = new Ev();

        }

        private void ListViewItem_MouseMove_4(object sender, MouseEventArgs e)
        {
            Main1.Content = false;
            Main.Content = new Kozmetik();
        }

        private void ListViewItem_MouseMove_5(object sender, MouseEventArgs e)
        {
            Main1.Content = false;
            Main.Content = new HobiDunyasi();
        }

        private void ListViewItem_MouseMove_6(object sender, MouseEventArgs e)
        {
            Main1.Content = false;
            Main.Content = new Spor();
        }

        private void ListViewItem_MouseMove_7(object sender, MouseEventArgs e)
        {
            Main1.Content = false;
            Main.Content = new Supermarket();
        }

        private void ListViewItem_MouseMove_8(object sender, MouseEventArgs e)
        {
            Main1.Content = false;
            Main.Content = new Otomobil();
        }

        private void ListViewItem_MouseMove_9(object sender, MouseEventArgs e)
        {
            Main1.Content = false;
            Main.Content = new Pet();
        }






        //private void ListViewItem_MouseMove_9(object sender, MouseEventArgs e)
        //{
        //    Main1.Content = false;
        //    Main.Content = new Pet();
        //}

        //private void ListViewItem_MouseLeave_8(object sender, MouseEventArgs e)
        //{
        //    Main.Content = false;
        //}
    }
}
