using Entities;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
    public interface IRepositorySubcategorias : IRepository<Subcategoria>
    {
        IEnumerable<Subcategoria> GetByCategoria(int idCategoria);
    }
}
