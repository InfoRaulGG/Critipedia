using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Categoria
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public ICollection<Subcategoria> Subcategorias { get; set; }

    }
}
