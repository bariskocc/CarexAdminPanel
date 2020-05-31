using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLteExample.Models
{
    public class CarBrands
    {
        [Key]
        public int Id { get; set; }

        public int BrandId { get; set; }

        [StringLength(150)]
        public string BrandName { get; set; }
    }
}