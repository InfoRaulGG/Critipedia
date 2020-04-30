using Dapper.Contrib.Extensions;
using Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace CritipediaDataAccess.Repositories
{
    public class RepositoryCategorias : Repository<Categoria>, IRepositoryCategorias
    {
        private IRepositorySubcategorias _repoSubcat;
        public RepositoryCategorias(string connectionStrings, IRepositorySubcategorias repoSubcat) : base(connectionStrings)
        {
            _repoSubcat = repoSubcat;
        }

        public override IEnumerable<Categoria> GetAll()
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                var categorias = con.GetAll<Categoria>();
                foreach(var c in categorias)
                {
                    c.Subcategorias = _repoSubcat.GetByCategoria(c.Id).ToList();
                }

                return categorias;
            }
        }
    }
}
