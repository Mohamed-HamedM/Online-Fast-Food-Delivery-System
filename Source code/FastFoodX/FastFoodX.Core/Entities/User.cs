using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodX.Core.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string HashedPassword { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string? Phone { get; set; }

        public Customer? Customer { get; set; }
        public DeliveryAgent? DeliveryAgent { get; set; }
        public Restaurant? Restaurant { get; set; }

        public ICollection<Report> Reports { get; set; } = new List<Report>();
    }
}

