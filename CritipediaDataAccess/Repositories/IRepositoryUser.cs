<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CritipediaDataAccess.Repositories
{
    public interface IRepositoryUser
    {

=======
﻿using Entities;

namespace CritipediaDataAccess.Repositories
{
    public interface IRepositoryUser : IRepository<User>
    {
        User ValidateUser(string email, string password);
>>>>>>> develop
    }
}
