using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace FLS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void mainFrame_Initialized(object sender, EventArgs e)
        {
           mainFrame.Navigate(new inputPage());       
        }

        private void inputLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
           mainFrame.Navigate(new inputPage());
        }

        private void activeLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new activePage());
        }

        private void endLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new endPage());
        }
    }
}
