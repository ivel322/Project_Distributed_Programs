using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Data.Entities
{
    public class Book : BaseEntity
    {
        [StringLength(20)]
        public string Author { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public int ISBN { get; set; }
        [StringLength(50)]
        public string Genre { get; set; }
        [StringLength(20)]
        public string Type { get; set; }
        public DateTime? Published { get; set; }
        [Required]
        public decimal Price { get; set; }

    }
}
