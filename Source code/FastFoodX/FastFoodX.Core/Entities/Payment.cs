using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodX.Core.Entities
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public string PaymentMethod { get; set; } = null!;
        public decimal Amount { get; set; }
        public string Status { get; set; } = null!;
        public string TransactionID { get; set; } = null!;
        public DateTime Timestamp { get; set; }

        public Order Order { get; set; } = null!;
    }
}

