using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMS.Models.DTO
{
    public class ProductCreateDTO
    {
        public string ProductName { get; set; }
        public int ProductUnitID { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
