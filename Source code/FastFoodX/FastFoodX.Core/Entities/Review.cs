using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodX.Core.Entities
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public int CustomerID { get; set; }
        public int RestaurantID { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime Timestamp { get; set; }

        public Customer Customer { get; set; } = null!;
        public Restaurant Restaurant { get; set; } = null!;
    }
}
