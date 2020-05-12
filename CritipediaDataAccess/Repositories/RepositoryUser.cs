<<<<<<< HEAD
﻿using Entities;
=======
﻿using Dapper;
using Dapper.Contrib.Extensions;
using Entities;
using Microsoft.Data.SqlClient;
>>>>>>> develop

namespace CritipediaDataAccess.Repositories
{
    public class RepositoryUser : Repository<User>, IRepositoryUser
    {
        public RepositoryUser(string connectionStrings) : base(connectionStrings)
        {
        }
<<<<<<< HEAD
=======

        public User ValidateUser(string email, string password)
        {

            using (var con = new SqlConnection(_connectionStrings))
            {
                string query = @"SELECT TOP 1 *
                                FROM Users
                                WHERE Email = @Email AND Password = @Password";

                var parameters = new { Email = email, Password = password };

                return con.QueryFirstOrDefault<User>(query, parameters);
            }

        }
>>>>>>> develop
    }
}
