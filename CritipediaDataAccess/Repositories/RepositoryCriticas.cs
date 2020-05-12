using Dapper;
<<<<<<< HEAD
using Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
=======
using Dapper.Contrib.Extensions;
using Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
>>>>>>> develop

namespace CritipediaDataAccess.Repositories
{
    public class RepositoryCriticas : Repository<Critica>, IRepositoryCriticas
    {
<<<<<<< HEAD
        public RepositoryCriticas(string connectionStrings) :base(connectionStrings)
        {
                
        }
=======
        public RepositoryCriticas(string connectionStrings, IRepositoryComentarios repoComentarios) :base(connectionStrings)
        {
        }

>>>>>>> develop
        public IEnumerable<Critica> GetLastFive()
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                string query = @"SELECT TOP 5 *
                                 FROM [dbo].Criticas
                                 Order by Fecha desc";

<<<<<<< HEAD
                return con.Query<Critica>(query);  
            }
        }

        public IEnumerable<Critica> GetTopFiveCategory()
=======
                return con.Query<Critica>(query);
            }
        }

        public IEnumerable<Critica> GetTopFiveCategory(int idCategoria)
>>>>>>> develop
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                string query = @"SELECT TOP 5 *
<<<<<<< HEAD
                                 FROM [dbo].Criticas
                                 Order by Fecha desc";

                return con.Query<Critica>(query);
            }
        }
=======
                                FROM [dbo].Criticas cr
                                INNER JOIN Subcategorias sc on cr.SubcategoriaId = sc.Id
                                INNER JOIN Categorias ca on sc.CategoriaId = ca.Id
                                WHERE ca.Id = 1
                                Order by Fecha desc";

                var parameters = new {CategoriaId = idCategoria };

                return con.Query<Critica>(query, parameters);
           
            }
        }


>>>>>>> develop
    }
}
