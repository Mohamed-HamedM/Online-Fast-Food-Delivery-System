using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodX.Core.Entities
{
    public class Restaurant
    {
        [Key]
        public int RestaurantID { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public int OwnerID { get; set; }

        public User Owner { get; set; } = null!;
        public ICollection<Menu> Menus { get; set; } = new List<Menu>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}

