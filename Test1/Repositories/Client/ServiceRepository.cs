using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Contexts.Client;
using Test1.Entities.Client;

namespace Test1.Repositories.Client
{
    public class ServiceRepository : BaseClientRepository, IServiceRepository
    {
        public ServiceRepository(DatabaseContextFactory databaseContextFactory):base(databaseContextFactory)
        {

        }

        public ServicesProvided getService(int serviceId)
        {
            return db.Services.Where(s => s.Id == serviceId).FirstOrDefault();
            
        }

        public IEnumerable<ServicesProvided> GetServices()
        {
            return db.Services.OrderBy(s => s.ServiceName).ToList();
        }
    }
}
