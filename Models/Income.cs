using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceManage.Models
{
    public class Income
    {
        [Key]
        public int incomeId { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]        
        [Required]
        public DateTime IncomeDate {get; set ;  }

        [Display(Name = "Shop Sales")]
        [Required]
        public double sales { get; set; } = 0;

        [Display(Name = "Othet Sales")]
        public double other { get; set; } = 0;
        public double total { get; set; } = 0;

        [Display(Name = "Net Sales")]
        public double netSales { get; set; } = 0;
        public double vat { get; set; } = 0;

        [Display(Name = "Gross Sales")]
        public double grossSales { get; set; } = 0;
        public double cash { get; set; }
        public double card { get; set; }
        public double credit { get; set; }

    }
}
