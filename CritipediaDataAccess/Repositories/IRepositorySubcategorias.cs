using Entities;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
    public interface IRepositorySubcategorias
    {
        IEnumerable<Subcategoria> GetByCategoria(int idCategoria);
    }
}
