using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodX.Core.Entities
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }
        public string ReportType { get; set; } = null!;
        public DateTime GeneratedDate { get; set; }
        public int GeneratedBy { get; set; }
        public string Summary { get; set; } = null!;
        public string? Details { get; set; }

        public User User { get; set; } = null!;
    }
}

