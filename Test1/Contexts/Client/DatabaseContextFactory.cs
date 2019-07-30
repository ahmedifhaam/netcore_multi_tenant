using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Contexts.Client
{
    public class DatabaseContextFactory
    {
        public DatabaseContext CreateDbContext(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var context = new DatabaseContext(optionsBuilder.Options);
            context.Database.EnsureCreated();
            return context;
        }
    }
}
