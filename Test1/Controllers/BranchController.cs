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

        private readonly ISystemRepository systemRepository;
        private readonly IBranchRepository branchRepository;

        public BranchController(ISystemRepository systemRepository,IBranchRepository branchRepository)
        {
            this.systemRepository = systemRepository;
            this.branchRepository = branchRepository;
        }

        [HttpGet]
        public IActionResult getBranches([FromQuery] int clientId)
        {

            if (clientId == default(int)) return BadRequest("Please Specify a ClientID");
            var connectionString = systemRepository.getConnectiongString(clientId);
            if (connectionString == null) return BadRequest("Client not found");
            branchRepository.InitializeDatabaseContext(connectionString);


            return Ok(branchRepository.getBranches());
        }

        [HttpGet("{branchId}")]
        public IActionResult getBranch([FromQuery] int clientId,int branchId)
        {
            if (clientId == default(int)) return BadRequest("Please Specify a ClientID");
            var connectionString = systemRepository.getConnectiongString(clientId);
            if (connectionString == null) return BadRequest("Client not found");
            branchRepository.InitializeDatabaseContext(connectionString);

            branchRepository.InitializeDatabaseContext(systemRepository.getConnectiongString(clientId));
            return Ok(branchRepository.getBranch(branchId));
        }
    }
}
