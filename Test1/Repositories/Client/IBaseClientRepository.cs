using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Repositories.Client
{
    public interface IBaseClientRepository
    {

        void InitializeDatabaseContext(string connectionString);
    }

}
