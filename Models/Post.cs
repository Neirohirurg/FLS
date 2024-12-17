using System;

namespace FLS.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string SupplyName { get; set; }
        public string Status { get; set; }
        public DateTime DeliveryDate { get; set; }

        public Post(int id, string supplyName, string status, DateTime deliveryDate)
        {
            Id = id;
            SupplyName = supplyName;
            Status = status;
            DeliveryDate = deliveryDate;
        }
    }
}
