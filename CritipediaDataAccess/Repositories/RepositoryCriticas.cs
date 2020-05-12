using Dapper;
using Dapper.Contrib.Extensions;
using Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace CritipediaDataAccess.Repositories
{
    public class RepositoryCriticas : Repository<Critica>, IRepositoryCriticas
    {
        public RepositoryCriticas(string connectionStrings, IRepositoryComentarios repoComentarios) :base(connectionStrings)
        {
        }

        public IEnumerable<Critica> GetLastFive()
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                string query = @"SELECT TOP 5 *
                                 FROM [dbo].Criticas
                                 Order by Fecha desc";

                return con.Query<Critica>(query);
            }
        }

        public IEnumerable<Critica> GetTopFiveCategory(int idCategoria)
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                string query = @"SELECT TOP 5 *
                                FROM [dbo].Criticas cr
                                INNER JOIN Subcategorias sc on cr.SubcategoriaId = sc.Id
                                INNER JOIN Categorias ca on sc.CategoriaId = ca.Id
                                WHERE ca.Id = 1
                                Order by Fecha desc";

                var parameters = new {CategoriaId = idCategoria };

                return con.Query<Critica>(query, parameters);
           
            }
        }


    }
}
