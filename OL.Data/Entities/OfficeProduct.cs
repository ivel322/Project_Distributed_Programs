using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Data.Entities
{
    public class OfficeProduct : BaseEntity
    {
        [StringLength(20)]
        public string Type { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [StringLength(50)]
        public string NameProduct { get; set; }
        [Required]
        public int BarCode { get; set; }
        [Required]
        public bool Available { get; set; }
    }
}
