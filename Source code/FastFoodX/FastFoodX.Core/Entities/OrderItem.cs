using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodX.Core.Entities
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int MenuID { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }

        public Order Order { get; set; } = null!;
        public Menu Menu { get; set; } = null!;
    }
}
