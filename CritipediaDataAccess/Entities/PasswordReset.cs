﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class PasswordReset
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string ResetCode { get; set; }
        [Required]
        public bool Active { get; set; }

        [Required]
        [ForeignKey("UserID")]
        public int UserID { get; set; } 
    }
}
