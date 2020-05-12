using System;
using System.Collections.Generic;
using System.Text;

namespace CritipediaDataAccess.Repositories
{
    public interface IRepository<T> where T:class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        int Insert(T entity);
        bool Delete(T entity);
        bool Update(T entity);

    }
}
