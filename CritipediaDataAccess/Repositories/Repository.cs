using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
=======
using System.Collections.Generic;
>>>>>>> develop

namespace CritipediaDataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected string _connectionStrings;
        public Repository(string connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }
<<<<<<< HEAD
=======


>>>>>>> develop
        public bool Delete(T entity)
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                return con.Delete(entity);
            }
        }

<<<<<<< HEAD
        public IEnumerable<T> GetAll()
=======
        public virtual IEnumerable<T> GetAll()
>>>>>>> develop
        {
            using (var con = new SqlConnection(_connectionStrings))
            {
                return con.GetAll<T>();
            }
        }

<<<<<<< HEAD
        public T GetById(int id)
=======
        public virtual T GetById(int id)
>>>>>>> develop
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
<<<<<<< HEAD
=======

        IEnumerable<T> IRepository<T>.GetAll()
        {
            throw new System.NotImplementedException();
        }
>>>>>>> develop
    }
}
