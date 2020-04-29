using CritipediaDataAccess.Repositories;
using System;

namespace CritipediaDataAccess
{
    public interface IUnitOfWork
    {
        
        IRepositoryCategorias RepositoryCategorias { get; }
        IRepositoryComentarios RepositoryComentarios { get; }
        IRepositoryCriticas RepositoryCriticas { get; }
        IRepositorySubcategorias RepositorySubcategorias { get; }
        IRepositoryUser RepositoryUser { get; }


    }
    public class UnitOfWork : IUnitOfWork
    {
        public IRepositoryCategorias RepositoryCategorias { get; }

        public IRepositoryComentarios RepositoryComentarios { get; }

        public IRepositoryCriticas RepositoryCriticas { get; }

        public IRepositorySubcategorias RepositorySubcategorias { get; }

        public IRepositoryUser RepositoryUser { get; }

        public UnitOfWork(string connectionString)
        {
            RepositoryCategorias = new RepositoryCategorias(connectionString);
            RepositoryComentarios = new RepositoryComentarios(connectionString);
            RepositoryCriticas = new RepositoryCriticas(connectionString);
            RepositorySubcategorias = new RepositorySubcategorias(connectionString);
            RepositoryUser = new RepositoryUser(connectionString);

        }
    }
}
