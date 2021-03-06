﻿using Entities;

namespace CritipediaDataAccess.Repositories
{
    public interface IRepositoryUser : IRepository<User>
    {
        User ValidateUser(string email, string password);
    }
}
