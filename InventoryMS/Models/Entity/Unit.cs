using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace InventoryMS.Models.Entity
{
    public class Unit
    {
        [Key]
        public int UnitID { get; set; }
        [Required]
        public string UnitName { get; set; }
    }
}
