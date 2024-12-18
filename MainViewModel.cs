using FLS.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;

namespace FLS
{
    public class MainViewModel
    {
        // Заявки 
        public ObservableCollection<State> Requests { get; set; }
        public ObservableCollection<State> ActiveRequests { get; set; }
        public ObservableCollection<State> CompletedRequests { get; set; }

        // Маршруты
        public ObservableCollection<Route> Routes { get; set; }
        // Поставки
        public ObservableCollection<Post> Supplies { get; set; }




        public MainViewModel()
        {
            Requests = new ObservableCollection<State>
            {
                new State(1, "Заявка 1", "Активна", DateTime.Now.AddDays(-3)),
                new State(2, "Заявка 2", "Завершена", DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1))
            };

            ActiveRequests = new ObservableCollection<State>(Requests.Where(r => r.Status == "Активна"));
            CompletedRequests = new ObservableCollection<State>(Requests.Where(r => r.Status == "Завершена"));
            
            
            Routes = new ObservableCollection<Route>
            {
                new Route(1, "Маршрут 1", "Завод 1", 25.5, 300.25),
                new Route(2, "Маршрут 2", "Завод 2", 8.9, 45.86),
                new Route(3, "Маршрут 3", "Завод 3", 16.6, 140.35),
                new Route(4, "Маршрут 4", "Завод 4", 7.9, 70.45),
                new Route(5, "Маршрут 5", "Завод 5", 13.8, 100.45),

            };

            Supplies = new ObservableCollection<Post>
            {
                new Post(1, "Поставка 1", "В пути", DateTime.Now.AddDays(-1)),
                new Post(2, "Поставка 2", "Доставлена", DateTime.Now.AddDays(-2))
            };

        }


        /* Заявки */


        // Метод для добавления новой заявки
        public void AddRequest(State request)
        {
            ActiveRequests.Add(request);
            UpdateCompletedRequests();
            UpdateActiveRequests();
        }

        // Метод для обновления коллекции заявок
        private void UpdateCompletedRequests()
        {
            ActiveRequests.Clear();
            foreach (var request in Requests.Where(r => r.Status == "Активна"))
            {
                ActiveRequests.Add(request);
            }
        }
        private void UpdateActiveRequests()
        {
            CompletedRequests.Clear();
            foreach (var request in Requests.Where(r => r.Status == "Завершена"))
            {
                CompletedRequests.Add(request);
            }
        }

        // Метод для изменения статуса заявки
        public void UpdateRequestStatus(int requestId, string newStatus)
        {
            var request = Requests.FirstOrDefault(r => r.Id == requestId);
            if (request != null)
            {
                request.Status = newStatus;
                UpdateCompletedRequests();
            }
        }



        /* Маршруты */

        public void AddRoute(Route route)
        {
            Routes.Add(route);
        }

        public void DeleteRoute(Route route)
        {
            Routes.Remove(route);
        }

        /*  */
    }
}
