<<<<<<< HEAD
﻿using Entities;
=======
﻿using Dapper.Contrib.Extensions;
using Entities;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
>>>>>>> develop

namespace CritipediaDataAccess.Repositories
{
    public class RepositoryCategorias : Repository<Categoria>, IRepositoryCategorias
    {
<<<<<<< HEAD
        public RepositoryCategorias(string connectionStrings) : base(connectionStrings)
=======
        public RepositoryCategorias(string connectionStrings, IRepositorySubcategorias repoSubcat) : base(connectionStrings)
>>>>>>> develop
        {
        }
    }
}
