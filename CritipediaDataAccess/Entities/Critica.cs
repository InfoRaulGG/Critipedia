using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Critica
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Anuncio { get; set; }
        [Required]
        public string Trailer { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public decimal Puntuacion{ get; set; }
        [Required]
        public string Imagen { get; set; }
        [Required]
        public string Portada { get; set; }

        [Required]
        [ForeignKey("SubcategoriaID")]
        public int SubcategoriaID { get; set; }

    }
}
