using Entities;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
<<<<<<< HEAD
    public interface IRepositorySubcategorias
=======
    public interface IRepositorySubcategorias : IRepository<Subcategoria>
>>>>>>> develop
    {
        IEnumerable<Subcategoria> GetByCategoria(int idCategoria);
    }
}
