using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gushv3.Models
{
    public class Sales
    {
        [Key]
        public int TransId { get; set; }
        [Display(Name = "Transaction Date")]
        public DateTime transDate { get; set; }
        [Display(Name = "Receipt No.")]
        public string OrNo { get; set; }

        [Display(Name = "Product")]
        public string product { get; set; }
        [Display(Name = "Quantity Purchased")]
        public int transQtyPurch { get; set; }
        [Display(Name = "Cashier")]
        public string cashier { get; set; }

    }
}