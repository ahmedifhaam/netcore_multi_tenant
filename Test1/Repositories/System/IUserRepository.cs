using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Models.System;

namespace Test1.Repositories.System
{
    public interface IUserRepository
    {

        IEnumerable<UserDto> GetUsers();

        UserDto GetUser(int userId);
    }
}
