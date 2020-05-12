using Entities;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
    public class RepositorySubcategorias : Repository<Subcategoria>, IRepositorySubcategorias
    {
        public RepositorySubcategorias(string connectionStrings) : base(connectionStrings)
        {
        }

        public IEnumerable<Subcategoria> GetByCategoria(int idCategoria)
        {
            throw new System.NotImplementedException();
        }
    }
}
