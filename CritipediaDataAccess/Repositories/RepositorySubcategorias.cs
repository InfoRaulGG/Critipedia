﻿using Dapper;
using Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
    public class RepositorySubcategorias : Repository<Subcategoria>, IRepositorySubcategorias
    {
        public RepositorySubcategorias(string connectionStrings) : base(connectionStrings)
        {
        }

        public IEnumerable<Subcategoria> GetByCategoria(int idCategoria)
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                string query = @"SELECT TOP 5 *
                                 FROM [dbo].Subcategorias
                                 WHERE CategoriaId = @CategoriaId";

                var parameters = new { CategoriaId = idCategoria };

                return con.Query<Subcategoria>(query, parameters);
            }
        }
    }
}
