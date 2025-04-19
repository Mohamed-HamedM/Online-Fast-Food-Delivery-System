using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodX.Core.Entities
{
    public class Promotion
    {
        [Key]
        public int PromoID { get; set; }
        public string Code { get; set; } = null!;
        public decimal DiscountPercentage { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string Status { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}

