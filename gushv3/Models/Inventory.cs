using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gushv3.Models
{
    public class Inventory
    {
        [Key]
       
        public int prodId { get; set; }
        [Display(Name = "Product")]
        public string prodName { get; set; }
        [Display(Name = "Stock Quantity")]
        public string prodStockQty { get; set; }
        [Display(Name = "Required Stock")]
        public string prodStockReq { get; set; }
        [Display(Name = "Price")]
        public decimal prodPrice { get; set; }
       
       




    }
}