using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMS.Models.Entity
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public Unit ProductUnit { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }






    }
}
