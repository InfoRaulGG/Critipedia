using Entities;
using System.Collections.Generic;

namespace CritipediaDataAccess.Repositories
{
    interface IRepositoryCriticas 
    {
        IEnumerable<Critica> GetLastFive();
        IEnumerable<Critica> GetTopFiveCategory();

    }
}
