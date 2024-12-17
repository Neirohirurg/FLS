using System;

namespace FLS.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CompletionDate { get; set; }

        // Конструктор
        public State(int id, string name, string status, DateTime createdDate, DateTime? completionDate = null)
        {
            Id = id;
            Name = name;
            Status = status;
            CreatedDate = createdDate;
            CompletionDate = completionDate;
        }
    }
}
