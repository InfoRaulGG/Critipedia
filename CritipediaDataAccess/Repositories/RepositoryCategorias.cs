using Dapper.Contrib.Extensions;
using Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace CritipediaDataAccess.Repositories
{
    public class RepositoryCategorias : Repository<Categoria>, IRepositoryCategorias
    {
        public RepositoryCategorias(string connectionStrings, IRepositorySubcategorias repoSubcat) : base(connectionStrings)
        {
        }
    }
}
