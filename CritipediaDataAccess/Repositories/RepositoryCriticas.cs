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
        public RepositoryCriticas(string connectionStrings) :base(connectionStrings)
        {
                
        }

        public override IEnumerable<Critica> GetAll()
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                var crits = con.GetAll<Critica>();
                foreach(var c in crits)
                {
                    c.Subcategoria = con.Get<Subcategoria>(c.SubcategoriaID);

                    string query = @"SELECT Descripcion, Nota, Fecha, CriticaId
                                     FROM Comentarios WHERE CriticaId = @CriticaId";
                    var parameters = new { CriticaId = c.Id };

                    c.Comentarios = con.Query<Comentario>(query, parameters).ToList();
                }

                return crits;
            }         
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
                                 FROM [dbo].Criticas
                                 WHERE CategoriaId = @CategoriaId
                                 Order by Fecha desc";
                var parameters = new {CategoriaId = idCategoria };

                return con.Query<Critica>(query, parameters);
            }
        }
    }
}
