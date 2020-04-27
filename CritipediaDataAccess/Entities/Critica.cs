using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Critica
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CriticaId { get; set; }
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


        public int SubcategoriaID { get; set; }
        public Subcategoria Subcategoria { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }


    }
}
