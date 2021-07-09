using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceManage.Models
{
    public class Item
    { 
        [Key]
        public int Id { get; set; }

        [DisplayName ("Supplier Name")]
        public string ItemName { get; set; }


    }
}
