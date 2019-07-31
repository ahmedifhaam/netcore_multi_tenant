using System;
using System.Collections.Generic;
using System.Text;
using Test1.Entities.Client;
using Test1.Repositories.Client;

namespace UnitTestProject1.Fakes
{
    public class BranchRepository : IBranchRepository
    {
        public Branch getBranch(int branchId)
        {
            return new Branch()
            {
                Id = branchId,
                BranchName = "Branch test",
                Location = "Branch test location"
            };
        }

        public IEnumerable<Branch> getBranches()
        {
            return new List<Branch>()
            {
               new Branch()
                    {
                        Id = 1,
                        BranchName = "Branch One",
                        Location = "Branch one location"
                    }, new Branch()
                    {
                        Id = 2,
                        BranchName = "Branch two",
                        Location = "Branch two location"
                    }
            };
        }

        public void InitializeDatabaseContext(string connectionString)
        {
            throw new NotImplementedException();
        }
    }
}
