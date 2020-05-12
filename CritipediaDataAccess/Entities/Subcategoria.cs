using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Subcategoria
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubcategoriaId { get; set; }
        [Required]
        public string Nombre { get; set; }

        [Required]
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}
