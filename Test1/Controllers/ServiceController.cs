using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test1.Entities.Client;
using Test1.Repositories.Client;
using Test1.Repositories.System;

namespace Test1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {

        IServiceRepository serviceRepository;
        private readonly ISystemRepository systemRepository;

        public ServiceController(ISystemRepository systemRepository, IServiceRepository serviceRepository)
        {
            this.serviceRepository = serviceRepository;
            this.systemRepository = systemRepository;
        }

        [HttpGet]
        public IActionResult GetServices([FromQuery] int clientId)
        {
            if (clientId == default(int)) return BadRequest("Invalid ClientId");
            var connectionString = systemRepository.getConnectiongString(clientId);
            if (connectionString == null) return BadRequest("Client not found");

            serviceRepository.InitializeDatabaseContext(connectionString);


            return Ok(serviceRepository.GetServices());

        }

        [HttpGet("{id}")]
        public IActionResult getService([FromQuery] int clientId,int id)
        {
            if (clientId == default(int)) return BadRequest("Invalid ClientId");
            var connectionString = systemRepository.getConnectiongString(clientId);
            if (connectionString == null) return BadRequest("Client not found");

            serviceRepository.InitializeDatabaseContext(connectionString);


            return Ok(serviceRepository.getService(id));
        }

    } 
}