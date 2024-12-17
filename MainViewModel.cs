using FLS.Models;
using System;
using System.Collections.ObjectModel;

namespace FLS
{
    public class MainViewModel
    {
        public ObservableCollection<State> Requests { get; set; }
        public ObservableCollection<Route> Routes { get; set; }
        public ObservableCollection<Post> Supplies { get; set; }

        public MainViewModel()
        {
            Requests = new ObservableCollection<State>
        {
            new State(1, "Заявка 1", "Активна", DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-2)),
            new State(2, "Заявка 2", "Завершена", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1))
        };

            Routes = new ObservableCollection<Route>
        {
            new Route(1, "Маршрут 1", DateTime.Now.AddDays(-1)),
            new Route(2, "Маршрут 2", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1))
        };

            Supplies = new ObservableCollection<Post>
        {
            new Post(1, "Поставка 1", "В пути", DateTime.Now.AddDays(-1)),
            new Post(2, "Поставка 2", "Доставлена", DateTime.Now.AddDays(-2))
        };
        }
    }
}
