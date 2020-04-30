using Entities;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
    public interface IRepositoryComentarios : IRepository<Comentario>
    {
        IEnumerable<Comentario> GetPaginated(int idCritica, int page, int rows);
        IEnumerable<Comentario> GetByCritica(int idCritica);


    }
}
