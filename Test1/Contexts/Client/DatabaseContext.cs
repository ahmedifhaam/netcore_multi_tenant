using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Entities.Client;

namespace Test1.Contexts.Client
{
    public class DatabaseContext:DbContext
    {

        public DbSet<Branch> Branches { get; set; }
        public DbSet<ServicesProvided> Services { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
    }
}
