using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Attribute.Models
{
    [Table("Table_Tag")]
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
      
        public int VendorId { get; set; }
        [ForeignKey("VendorId")]
        public Vendor vendor { get; set; }

    }
}
