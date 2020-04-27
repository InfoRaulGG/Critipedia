using Dapper;
using Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
    public class RepositorioComentarios : Repository<IRepositoryComentarios>, IRepositoryComentarios
    {
        public RepositorioComentarios(string connectionStrings) : base(connectionStrings)
        {

        }
        public IEnumerable<Comentario> GetPaginated(int idCritica, int page, int rows)
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                string query = @$"SELECT *
                                 FROM [dbo].Comentario
                                 WHERE CriticaId = {idCritica} 
                                 Order by Fecha desc  
                                 OFFSET ({page - 1}) * {rows} ROWS 
                                 FETCH NEXT {rows} ROWS ONLY;";

                return con.Query<Comentario>(query);
            }
        }
    }
}
