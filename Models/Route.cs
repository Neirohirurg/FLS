using System;

namespace FLS.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string RouteName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Route(int id, string routeName, DateTime startDate, DateTime? endDate = null)
        {
            Id = id;
            RouteName = routeName;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
