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
            RepositorySubcategorias = new RepositorySubcategorias(connectionString);
            RepositoryUser = new RepositoryUser(connectionString);
            RepositoryCategorias = new RepositoryCategorias(connectionString, RepositorySubcategorias);
            RepositoryComentarios = new RepositoryComentarios(connectionString, RepositoryUser);
            RepositoryCriticas = new RepositoryCriticas(connectionString, RepositoryComentarios);

        }
    }
}
