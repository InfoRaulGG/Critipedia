using Dapper;
using Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
    public class RepositoryCriticas : Repository<Critica>, IRepositoryCriticas
    {
        public RepositoryCriticas(string connectionStrings) :base(connectionStrings)
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

        public IEnumerable<Critica> GetTopFiveCategory()
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                string query = @"SELECT TOP 5 *
                                 FROM [dbo].Criticas
                                 Order by Fecha desc";

                return con.Query<Critica>(query);
            }
        }
    }
}
