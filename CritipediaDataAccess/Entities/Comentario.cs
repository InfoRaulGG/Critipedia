using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Comentario
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ComentarioId { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public decimal Nota { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        [ForeignKey("UserId")]
        public User Usuario { get; set; }
        public int UserId { get; set; }

        [Required]
        [ForeignKey("CriticaId")]
        public Critica Critica { get; set; }
        public int CriticaId { get; set; }

    }
}
