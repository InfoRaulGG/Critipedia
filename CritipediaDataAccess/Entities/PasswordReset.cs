using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class PasswordReset
    {
        [Key]
<<<<<<< HEAD
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaswordResetId { get; set; }
=======
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
>>>>>>> develop
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string ResetCode { get; set; }
        [Required]
        public bool Active { get; set; }

<<<<<<< HEAD
        public User User { get; set; } 
=======
        [Required]
        [ForeignKey("UserID")]
        public int UserID { get; set; } 
>>>>>>> develop
    }
}
