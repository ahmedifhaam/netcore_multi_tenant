using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Contexts.Client;
using Test1.Entities.Client;

namespace Test1.Repositories.Client
{
    public class BranchRepository:BaseClientRepository
    {

        public BranchRepository(DatabaseContextFactory databaseContextFactory) :base(databaseContextFactory)
        {

        }

        public IEnumerable<Branch> getBranches()
        {
            return db.Branches.OrderBy(b => b.BranchName).ToList();
        }

        public Branch getBranch(int branchId)
        {
            return db.Branches.Where(b => b.Id == branchId).FirstOrDefault();
        }


    }
}
