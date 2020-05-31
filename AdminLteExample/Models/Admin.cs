using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdminLteExample.Models
{
    public partial class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }
    }
}
