using System;
using System.Collections.Generic;
using System.Text;
using Test1.Entities.System;
using Test1.Repositories.System;

namespace UnitTestProject1.Fakes
{
    class SystemRepository : ISystemRepository
    {
        public ClientEntity getClientForId(int clientId)
        {
            return new ClientEntity()
            {
                ClientId = clientId,
                ClientName = "Client Test",
                Username = "username",
                Password = "password",
                Server = "(localdb)\\mssqllocaldb",
                DatabaseName = "EFProviders.InMemory",

            };
        }

        public string getConnectiongString(int clientId)
        {
            return "Server=(localdb)\\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0";
        }
    }
}
