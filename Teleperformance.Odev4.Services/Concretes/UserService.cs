using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teleperformance.Odev4.Data.Context;
using Teleperformance.Odev4.Data.Dto;
using Teleperformance.Odev4.Entity;
using Teleperformance.Odev4.Services.Abstractions;

namespace Teleperformance.Odev4.Services.Concretes
{
    internal class UserService : IUserService
    {
        private readonly TlpDbContext _context;

        public UserService(TlpDbContext context)
        {
            _context = context;
        }

        public List<GetAllUserDto> GetAllUsers()
        {
            var data = _context.Users.Select(x => new GetAllUserDto
            {
                UserName = x.UserName,
                Email=x.Email,  
                IsActive=x.IsActive,
                IsDeleted=x.IsDeleted
            }).ToList();

            return data;
        }
    }

 
}
