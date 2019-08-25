using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Entities.Client;

namespace Test1.Repositories.Client
{
    public interface IBranchRepository:IBaseClientRepository
    {
        IEnumerable<Branch> getBranches();

        Branch getBranch(int branchId);
    }
}
