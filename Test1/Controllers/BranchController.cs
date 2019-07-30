using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Entities.Client;
using Test1.Repositories.Client;
using Test1.Repositories.System;

namespace Test1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BranchController:Controller
    {

        private readonly SystemRepository systemRepository;
        private readonly BranchRepository branchRepository;

        public BranchController(SystemRepository systemRepository,BranchRepository branchRepository)
        {
            this.systemRepository = systemRepository;
            this.branchRepository = branchRepository;
        }

        [HttpGet]
        public IActionResult getBranches([FromQuery] int clientId)
        {
            branchRepository.InitializeDatabaseContext(systemRepository.getConnectiongString(clientId));
            return Ok(branchRepository.getBranches());
        }

        [HttpGet("{branchId}")]
        public IActionResult getBranch([FromQuery] int clientId,int branchId)
        {
            branchRepository.InitializeDatabaseContext(systemRepository.getConnectiongString(clientId));
            return Ok(branchRepository.getBranch(branchId));
        }
    }
}
