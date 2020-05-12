using Entities;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
<<<<<<< HEAD
    interface IRepositoryCriticas 
    {
        IEnumerable<Critica> GetLastFive();
        IEnumerable<Critica> GetTopFiveCategory();
=======
    public interface IRepositoryCriticas : IRepository<Critica>
    {
        IEnumerable<Critica> GetLastFive();
        IEnumerable<Critica> GetTopFiveCategory(int idCategoria);
>>>>>>> develop

    }
}
