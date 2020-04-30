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

                foreach(var c in comentarios)
                {
                    c.Usuario = _repoUser.GetById(c.UserId);
                }

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

                foreach (var c in comentarios)
                {
                    c.Usuario = _repoUser.GetById(c.UserId);
                }

                return comentarios;
            }
        }
        public IEnumerable<Comentario> GetPaginated(int idCritica, int page, int rows)
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                string query = @$"SELECT *
                                 FROM [dbo].Comentarios
                                 WHERE CriticaId = {idCritica} 
                                 Order by Fecha desc  
                                 OFFSET ({page - 1}) * {rows} ROWS 
                                 FETCH NEXT {rows} ROWS ONLY;";

                var comentarios = con.Query<Comentario>(query);

                foreach (var c in comentarios)
                {
                    c.Usuario = _repoUser.GetById(c.UserId);
                }

                return comentarios;
            }
        }

    }
}
