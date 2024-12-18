using FLS.Models;
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


namespace FLS.Pages.RoutePages
{
    /// <summary>
    /// Логика взаимодействия для addRoutePage.xaml
    /// </summary>
    public partial class addRoutePage : Page
    {
        public addRoutePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel viewModel = (MainViewModel)Application.Current.Resources["MainViewModel"];

            string routeName = RouteNameTextBox.Text;
            string from = FromTextBox.Text;
            string avgDurationText = AvgDurationTextBox.Text;
            string maxWeightText = MaxWeightTextBox.Text;

            // Доделать!!!
            
            
                var newRoute = new Route(viewModel.Routes.Count() + 1, routeName, from, Convert.ToDouble(avgDurationText), Convert.ToDouble(maxWeightText));

                viewModel.AddRoute(newRoute);
                MessageBox.Show("Маршрут добавлен!");

                RouteNameTextBox.Clear();
                FromTextBox.Clear();
                AvgDurationTextBox.Clear();
                MaxWeightTextBox.Clear();
            
               // MessageBox.Show("Введите корректные данные для продолжительности и веса", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
