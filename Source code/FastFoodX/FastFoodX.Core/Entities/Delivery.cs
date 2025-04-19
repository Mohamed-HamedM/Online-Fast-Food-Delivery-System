using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FastFoodX.Core.Entities
{
    public class Delivery
    {
        [Key]
        public int DeliveryID { get; set; }
        public int OrderID { get; set; }
        public int AgentID { get; set; }
        public string DeliveryStatus { get; set; } = null!;
        public DateTime? DeliveryDate { get; set; }
        public DateTime? EstimatedDeliveryTime { get; set; }

        public Order Order { get; set; } = null!;
        public DeliveryAgent Agent { get; set; } = null!;
    }
}

