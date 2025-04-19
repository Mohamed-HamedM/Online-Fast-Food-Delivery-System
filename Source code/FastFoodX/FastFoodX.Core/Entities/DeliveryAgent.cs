using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FastFoodX.Core.Entities
{
    public class DeliveryAgent
    {
        [Key]
        public int AgentID { get; set; }
        public int UserID { get; set; }
        public bool IsAvailable { get; set; }
        public string? CurrentLocation { get; set; }

        public User User { get; set; } = null!;
        public ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();
    }
}

