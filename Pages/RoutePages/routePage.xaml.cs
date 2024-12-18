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
using FLS.Models;

namespace FLS.Pages.RoutePages
{
    /// <summary>
    /// Логика взаимодействия для routePage.xaml
    /// </summary>
    public partial class routePage : Page
    {
        public Route ChosenRoute { get; set; }

        public routePage()
        {
            InitializeComponent();
        }

        private void RouteListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = RouteListView.SelectedItem as Route;
            if (selectedItem != null) 
            {
                ChosenRoute = selectedItem;
            }
        }
    }
}
