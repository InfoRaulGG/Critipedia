using Dapper;
using Dapper.Contrib.Extensions;
using Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
    public class RepositoryComentarios : Repository<Comentario>, IRepositoryComentarios
    {
        private IRepositoryUser _repoUser;
        public RepositoryComentarios(string connectionStrings, IRepositoryUser repoUser) : base(connectionStrings)
        {
            _repoUser = repoUser;
        }
        public override IEnumerable<Comentario> GetAll()
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                var comentarios = con.GetAll<Comentario>();

                //foreach(var c in comentarios)
                //{
                //    c.Usuario = _repoUser.GetById(c.UserId);
                //}

                return comentarios;
            }
        }
        public IEnumerable<Comentario> GetByCritica(int idCritica)
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                string query = @$"SELECT *
                                 FROM [dbo].Comentarios
                                 WHERE CriticaId = {idCritica} 
                                 Order by Fecha desc";

                var comentarios = con.Query<Comentario>(query);

                //foreach (var c in comentarios)
                //{
                //    c.Usuario = _repoUser.GetById(c.UserId);
                //}

                return comentarios;
            }
        }
        public IEnumerable<Comentario> GetPaginated(int idCritica, int page, int rows)
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                string query = @$"SELECT * 
	                            FROM [dbo].Comentarios
	                            WHERE CriticaId = @CriticaId
	                            ORDER BY Fecha desc
	                            OFFSET @rows * (@page - 1) ROWS 
	                            FETCH NEXT @rows ROWS ONLY;";
                
                var parameters = new {CriticaId =  idCritica, page = page, rows = rows};
                var comentarios = con.Query<Comentario>(query, parameters);

                return comentarios;
            }
        }

    }
}
