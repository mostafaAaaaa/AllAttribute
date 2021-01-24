using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Attribute.Models
{
    //[NotMapped]
    public class Vendor
    {
        public Vendor()
        {

            Tags = new HashSet<Tag>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public String VendorName { get; set; }
        [Required]
        public String Title { get; set; }
        [MaxLength(11)]
        [Column("Phone") ]
        public string PhoneNumber { get; set; }
        //[NotMapped]
        public string Email { get; set; }

        public bool Gender { get; set; }

        public string Adress { get; set; }

        public DateTime Date { get; set; }

      //  [ForeignKey("VendorId")]

        public ICollection<Tag> Tags { get; set; }
    }
}
