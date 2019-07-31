using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Contexts.System;
using Test1.Entities.System;

namespace Test1.Repositories.System
{
    public class SystemRepository:ISystemRepository

    {
        private SystemDbContext _systemDbContext;

       

        public SystemRepository(SystemDbContext systemDbContext)
        {
            _systemDbContext = systemDbContext;
        }


        public string getConnectiongString(int clientId)
        {
            return buildConnectionStringFromClient(getClientForId(clientId));
        }

        public ClientEntity getClientForId(int clientId)
        {
            return _systemDbContext.Clients.Where(c => c.ClientId == clientId).FirstOrDefault();
        }


        private string buildConnectionStringFromClient(ClientEntity client)
        {
            if (client == default(ClientEntity)) return null;
            //AHMED - I\\SQLSERVERIFHAAM; Database = SystemDb; Trusted_Connection = True
            StringBuilder builder = new StringBuilder("Server=");
            builder.Append(client.Server).Append(";")
                .Append("Database=").Append(client.DatabaseName).Append(";")
                .Append("Trusted_Connection=True");
            Debug.WriteLine(builder.ToString());
            return builder.ToString();
        }

    }
}
