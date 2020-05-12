using Entities;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
    public interface IRepositoryCriticas : IRepository<Critica>
    {
        IEnumerable<Critica> GetLastFive();
        IEnumerable<Critica> GetTopFiveCategory(int idCategoria);

    }
}
