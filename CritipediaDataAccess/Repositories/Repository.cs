using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CritipediaDataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected string _connectionStrings;
        public Repository(string connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }


        public bool Delete(T entity)
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                return con.Delete(entity);
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                return con.GetAll<T>();
            }
        }

        public T GetById(int id)
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                return con.Get<T>(id);
            }
        }

        public int Insert(T entity)
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                return (int)con.Insert(entity);
            }
        }

        public bool Update(T entity)
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                return con.Update(entity);
            }
        }
    }
}
