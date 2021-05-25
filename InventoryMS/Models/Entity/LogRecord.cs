using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMS.Models.Entity
{
    public class LogRecord
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime AddedAt { get; set; }
        [Required]
        public string Body { get; set; }
    }
}
