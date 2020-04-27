using Entities;

namespace CritipediaDataAccess.Repositories
{
    public class RepositoryUser : Repository<User>, IRepositoryUser
    {
        public RepositoryUser(string connectionStrings) : base(connectionStrings)
        {
        }
    }
}
