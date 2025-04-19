using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodX.Core.Entities
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string ItemName { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int RestaurantID { get; set; }

        public Restaurant Restaurant { get; set; } = null!;
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
