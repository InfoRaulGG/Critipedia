using Entities;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
<<<<<<< HEAD
    public interface IRepositoryComentarios
    {
        IEnumerable<Comentario> GetPaginated(int idCritica, int page, int rows);
=======
    public interface IRepositoryComentarios : IRepository<Comentario>
    {
        IEnumerable<Comentario> GetPaginated(int idCritica, int page, int rows);
        IEnumerable<Comentario> GetByCritica(int idCritica);

>>>>>>> develop

    }
}
