using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Services.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<UserEntity> _repository;
        private readonly IMapper mapper;

        public UserService(IRepository<UserEntity> repository, IMapper mapper)
        {
            _repository = repository;
            this.mapper = mapper;
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Get()
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Get(Guid id)
        {
            throw new NotImplementedException();        
        }

        public Task<UserCreateResultDto> Post(UserCreateDto user)
        {
            throw new NotImplementedException();
        }

        public Task<UserUpdateResultDto> Put(UserUpdateDto user)
        {
            throw new NotImplementedException();
        }
    }
}
