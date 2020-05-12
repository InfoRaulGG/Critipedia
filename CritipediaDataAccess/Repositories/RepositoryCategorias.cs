using Entities;

namespace CritipediaDataAccess.Repositories
{
    public class RepositoryCategorias : Repository<Categoria>, IRepositoryCategorias
    {
        public RepositoryCategorias(string connectionStrings) : base(connectionStrings)
        {
        }
    }
}
