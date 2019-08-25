using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Entities.System;

namespace Test1.Repositories.System
{
    public interface ISystemRepository
    {
        string getConnectiongString(int clientId);

        ClientEntity getClientForId(int clientId);

      
    }
}
