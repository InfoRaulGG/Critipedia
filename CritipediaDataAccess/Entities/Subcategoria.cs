using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Subcategoria
    {
        [Key]
<<<<<<< HEAD
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubcategoriaId { get; set; }
        [Required]
        public string Nombre { get; set; }

        [Required]
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
=======
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [ForeignKey("CategoriaId")]
>>>>>>> develop
        public int CategoriaId { get; set; }
    }
}
