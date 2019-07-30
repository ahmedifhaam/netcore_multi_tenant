using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Contexts.Client;

namespace Test1.Repositories.Client
{
    public class BaseClientRepository
    {

        protected DatabaseContext db;

        private readonly DatabaseContextFactory contextFactory;

        public BaseClientRepository(DatabaseContextFactory contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public void InitializeDatabaseContext(string connectionString)
        {
            db = contextFactory.CreateDbContext(connectionString);
        }
    }
}
