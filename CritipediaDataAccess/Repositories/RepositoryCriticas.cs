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
        private IRepositoryComentarios _repoComentarios;
        public RepositoryCriticas(string connectionStrings, IRepositoryComentarios repoComentarios) :base(connectionStrings)
        {
            _repoComentarios = repoComentarios;
        }

        public override IEnumerable<Critica> GetAll()
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                var crits = con.GetAll<Critica>();
                foreach(var c in crits)
                {
                    c.Subcategoria = con.Get<Subcategoria>(c.SubcategoriaID);

                    c.Comentarios = _repoComentarios.GetByCritica(c.Id).ToList();
                }

                return crits;
            }         
        }

        public override Critica GetById(int id)
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                var crit = con.Get<Critica>(id);
                crit.Subcategoria = con.Get<Subcategoria>(crit.SubcategoriaID);
                crit.Comentarios = _repoComentarios.GetByCritica(crit.Id).ToList();

                return crit;
            }
        }
        public IEnumerable<Critica> GetLastFive()
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                string query = @"SELECT TOP 5 *
                                 FROM [dbo].Criticas
                                 Order by Fecha desc";

                var crits = con.Query<Critica>(query);

                foreach (var c in crits)
                {
                    c.Subcategoria = con.Get<Subcategoria>(c.SubcategoriaID);

                    c.Comentarios = _repoComentarios.GetByCritica(c.Id).ToList();
                }

                return crits;
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

                var crits = con.Query<Critica>(query, parameters);

                foreach (var c in crits)
                {
                    c.Subcategoria = con.Get<Subcategoria>(c.SubcategoriaID);

                    c.Comentarios = _repoComentarios.GetByCritica(c.Id).ToList();
                }

                return crits;
            }
        }
    }
}
