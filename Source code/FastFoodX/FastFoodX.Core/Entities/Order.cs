using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodX.Core.Entities
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = null!;
        public int CustomerID { get; set; }
        public int? PromoID { get; set; }

        public Customer Customer { get; set; } = null!;
        public Promotion? Promotion { get; set; }
        public Payment? Payment { get; set; }
        public Delivery? Delivery { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}

