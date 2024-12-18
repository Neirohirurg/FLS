using System;

namespace FLS.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string RouteName { get; set; }
        public string From { get; set; }
        public double AvgDuration { get; set; }
        public double MaxWeight { get; set; }

        public Route(int id, string routeName, string from, double avgDuration, double maxWeight)
        {
            Id = id;
            RouteName = routeName;
            From = from;
            AvgDuration = avgDuration;
            MaxWeight = maxWeight;          
        }
    }
}
