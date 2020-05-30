using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdminLteExample.Models
{
    public partial class CustomerDetails
    {
        public int Id { get; set; }

        public string Operation { get; set; }

        public DateTime? OperationDate { get; set; }

        public decimal OperationCost { get; set; }

        public int? CustomerId { get; set; }
    }
}
