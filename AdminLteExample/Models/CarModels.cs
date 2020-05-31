using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLteExample.Models
{
    public class CarModels
    {
        [Key]
        public int Id { get; set; }

        public int ModelId { get; set; }

        [StringLength(150)]
        public string ModelName { get; set; }

        [StringLength(150)]
        public string Category { get; set; }

        public int BrandId { get; set; }

        //public CarBrands CarBrands { get; set; }

    }
}