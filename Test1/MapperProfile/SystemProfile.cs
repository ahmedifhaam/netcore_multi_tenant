using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Entities.System;
using Test1.Models.System;

namespace Test1.MapperProfile
{
    public class SystemProfile:Profile
    {
        public SystemProfile()
        {
            CreateMap<UserEntity, UserDto>();
        }
    }
}
