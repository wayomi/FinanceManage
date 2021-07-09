using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceManage.Models
{
    public class Purchase
    {
        [Key]
        public int purchaseId { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime puchaseDate { get; set; }

        [Display(Name = "Invoice No")]
        [Required]
        public string InvoiceNo { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        public List<Item> supplier { get; set; }
       
        public float Amount { get; set; }

        [Display(Name = "VAT (%)")]
        public float vat { get; set; }

        [Display(Name = "Total Amount")]
        public float total { get; set; }

        [Display(Name = "First Payment")]
        public float firstPayment { get; set; }

        [Display(Name = "Second Payment")]
        public float secondPayment { get; set; }

        [Display(Name = "Payment Date (1st)")]
        [DataType(DataType.Date)]
        public DateTime firstPaidDate { get; set; }

        [Display(Name = "Payment Date (2nd)")]
        [DataType(DataType.Date)]
        public DateTime secondPaidDate { get; set; }

        [Display(Name = "Payment Type")]
        public string paymentType { get; set; }

    }
}
