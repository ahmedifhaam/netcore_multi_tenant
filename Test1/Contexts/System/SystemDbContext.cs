using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Entities.System;

namespace Test1.Contexts.System
{
    public class SystemDbContext:DbContext
    {
        public DbSet<ClientEntity> Clients { get; set; }
       

        public DbSet<UserEntity> Users { get; set; }

        public SystemDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach(var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.Relational().TableName = entityType.Relational().TableName.Replace("Entity","");

            }

        }
    }
}
