using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Data.Entities
{
    public class Order : BaseEntity
    {
        [Required]
        public DateTime Ordered { get; set; }
        public bool Arrived { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        [Required]
        public decimal FullPrice { get; set; }

    }
}
