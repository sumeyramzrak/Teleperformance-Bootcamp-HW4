﻿using Teleperformance.Odev4.Data.Dto;

namespace Teleperformance.Odev4.Services.Abstractions
{
    public interface IUserService
    {
        List<GetAllUserDto> GetAllUsers();
    }
}
