using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodX.Core.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string Address { get; set; } = null!;

        public User User { get; set; } = null!;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}

