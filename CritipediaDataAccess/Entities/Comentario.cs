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
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public decimal Nota { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [ForeignKey("UserId")]
        public User Usuario { get; set; }
        [Required]
        public int UserId { get; set; }

        [ForeignKey("CriticaId")]
        public Critica Critica { get; set; }
        [Required]
        public int CriticaId { get; set; }

    }
}
