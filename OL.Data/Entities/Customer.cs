using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Data.Entities
{
    public class Customer : BaseEntity
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        public DateTime? Birth { get; set; }
        [Required]
        [StringLength(300)]
        public string Adress { get; set; }
        [Required]
        public short PostCode { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
    }
}
