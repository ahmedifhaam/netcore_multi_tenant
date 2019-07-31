using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test1.Repositories.System;

namespace Test1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult getUsers()
        {
            var Users = userRepository.GetUsers();

            return Ok(Users);

        }

        [HttpGet("{UserId}")]
        public IActionResult getUser(int UserId)
        {
            if (UserId == default(int)) return BadRequest("Invalid User Id");
            return Ok(userRepository.GetUser(UserId));
        }
    }
}