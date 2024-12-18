using FLS.Pages;
using FLS.Pages.StatePages;
using FLS.Pages.RoutePages;
using FLS.Pages.PostPages;
using FLS.Pages.HistoryPages;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using FLS.Models;

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
            StartApp();
        }

        private void StartApp()
        {
            TimerInit();
            UpdateBorderWidthBasedOnNavigationPanel(stack1, navBar1);
            
        }

        private void mainFrame_Initialized(object sender, EventArgs e)
        {
            mainFrame.Navigate(new statePage());
        }

        private void activeLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new statePage());
        }

        private void endLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new endPage());
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;

            string formattedDateTime = currentDateTime.ToString("dd.MM.yyyy HH:mm:ss");

            dateLabel.Content = formattedDateTime;
        }

        private DispatcherTimer _timer;

        private void TimerInit()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;

            string formattedDateTime = currentDateTime.ToString("dd.MM.yyyy HH:mm:ss");

            dateLabel.Content = formattedDateTime;
        }

        private void UpdateBorderWidthBasedOnNavigationPanel(StackPanel stack, Border navBar)
        {
            int numberOfItems = stack.Children.Count;
            double itemWidth = 155;
            double totalWidth = numberOfItems * itemWidth;


            DoubleAnimation widthAnimation = new DoubleAnimation
            {
                From = 0,
                To = totalWidth,
                Duration = TimeSpan.FromSeconds(0.3)
            };

            navBar.BeginAnimation(Border.WidthProperty, widthAnimation);
        }
        private void SetActiveNavBar(int activeNavBarIndex)
        {
            navBar1.Visibility = Visibility.Collapsed;
            navBar2.Visibility = Visibility.Collapsed;
            navBar3.Visibility = Visibility.Collapsed;
            navBar4.Visibility = Visibility.Collapsed;

            switch (activeNavBarIndex)
            {
                case 1:
                    navBar1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    navBar2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    navBar3.Visibility = Visibility.Visible;
                    break;
                case 4:
                    navBar4.Visibility = Visibility.Visible;
                    break;
                default:
                    navBar1.Visibility = Visibility.Collapsed;
                    navBar2.Visibility = Visibility.Collapsed;
                    navBar3.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            SetActiveNavBar(1);
            mainFrame.Navigate(new statePage());
            UpdateBorderWidthBasedOnNavigationPanel(stack1, navBar1);
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            SetActiveNavBar(2);
            mainFrame.Navigate(new routePage());
            UpdateBorderWidthBasedOnNavigationPanel(stack2, navBar2);
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SetActiveNavBar(3);
            UpdateBorderWidthBasedOnNavigationPanel(stack3, navBar3);
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            SetActiveNavBar(4);
            UpdateBorderWidthBasedOnNavigationPanel(stack4, navBar4);
        }

        private void newRoute_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new addRoutePage());
        }

        private void delRoute_MouseDown(object sender, MouseButtonEventArgs e)
        {

            var routePage = (routePage)mainFrame.Content;
            var viewModel1 = (MainViewModel)routePage.DataContext;
            var selectedRoute = routePage.ChosenRoute;

            if (routePage != null && selectedRoute != null)
            {
                MessageBoxResult result = MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    viewModel1.DeleteRoute(selectedRoute);                
                    MessageBox.Show("Маршрут удален");
                }
                else
                {
                    mainFrame.Navigate(routePage);
                }
            }
            else
            {
                MessageBox.Show("Нажмите на любой элемент из списка");
            }
        }
    }
}
