
using Domain.Dtos.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services.User
{
    public interface IUserService
    {
        Task<List<UserDto>> Get();
        Task<UserDto> Get(Guid id);
        Task<UserCreateResultDto> Post(UserCreateDto user);
        Task<UserUpdateResultDto> Put(UserUpdateDto user);
        Task<bool> Delete(Guid id);
        
    }
}
