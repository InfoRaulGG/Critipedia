using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Comentario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public decimal Nota { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [ForeignKey("UserId")]
        [Required]
        public int UserId { get; set; }
        [ForeignKey("CriticaId")]
        [Required]
        public int CriticaId { get; set; }

    }
}
