using System;
using System.Collections.Generic;

namespace AdminLteExample.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string CarPlate { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string VehicleType { get; set; }
        public string Email { get; set; }
    }
}
