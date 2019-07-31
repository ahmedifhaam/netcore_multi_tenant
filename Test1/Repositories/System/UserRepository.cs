using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Contexts.System;
using Test1.Entities.System;
using Test1.Models.System;

namespace Test1.Repositories.System
{


    public class UserRepository : IUserRepository
    {
        private SystemDbContext _context;
        private MapperConfiguration mapperConfiguration;

        public UserRepository(SystemDbContext context, MapperConfiguration mapperConfiguration)
        {
            _context = context;
            this.mapperConfiguration = mapperConfiguration;
        }

        public IEnumerable<UserDto> GetUsers()
        {
            return _context.Users.OrderBy(u => u.Username)
                            .ProjectTo<UserDto>(mapperConfiguration)
                            .ToList();
        }

        public UserDto GetUser(int userId)
        {
            return _context.Users.Where(u => u.Id == userId)
                .ProjectTo<UserDto>(mapperConfiguration)
                .FirstOrDefault<UserDto>();
        }

        public int AddUser(UserCreationDto user)
        {
            var client = _context.Clients.Where(c => c.ClientId == user.ClientEntityId)
                 .FirstOrDefault();

            if (client == null) return -1;
            UserEntity userEntity = mapperConfiguration.CreateMapper()
                .Map<UserEntity>(user);

            userEntity.ClientEntityId = client.ClientId;
            userEntity.ClientEntity = client;

            _context.Users.Add(userEntity);
            if (_context.SaveChanges() > 0)
            {
                return userEntity.Id;
            }
            else
            {
                return -1;
            }
        }
    }
}
