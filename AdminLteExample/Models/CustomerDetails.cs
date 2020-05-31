using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace AdminLteExample.Models
{
    public partial class CustomerDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Operation { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OperationDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal OperationCost { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
