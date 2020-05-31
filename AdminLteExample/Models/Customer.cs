using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminLteExample.Models
{
    public partial class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string CarPlate { get; set; }

        [Required]
        [StringLength(150)]
        public string Brand { get; set; }

        [Required]
        [StringLength(150)]
        public string Model { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string VehicleType { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
