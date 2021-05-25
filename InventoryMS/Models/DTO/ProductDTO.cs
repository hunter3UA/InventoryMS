using InventoryMS.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMS.Models.DTO
{
    public class ProductDTO
    {
        
        public int ProductID { get; set; }
       
        public string ProductName { get; set; }
     
        public Unit ProductUnit { get; set; }
    
        public decimal ProductPrice { get; set; }
    }
}
