using Entities;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
    public interface IRepositoryComentarios
    {
        IEnumerable<Comentario> GetPaginated(int idCritica, int page, int rows);

    }
}
