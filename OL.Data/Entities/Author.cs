using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Data.Entities
{
    public class Author : BaseEntity
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        public DateTime? Birth { get; set; }
        [StringLength(50)]
        public string Genre { get; set; }
        public int NumberOfBooks { get; set; }
    }
}
