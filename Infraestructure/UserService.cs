﻿using AutoMapper;
using Domain.Dtos.User;
using Domain.Entities.User;
using Domain.Interfaces;
using Domain.Mapper.Interface;
using Domain.Services.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{    
    public class UserService : IUserService
    {
        private readonly IRepository<UserEntity> _repository;
        private readonly IMapper mapper;

        public UserService(IRepository<UserEntity> repository, IMapperService mapper)
        {
            _repository = repository;
            this.mapper = mapper.GetMapper();
        }

        public async Task<bool> Delete(Guid id)
        {
            var result = await _repository.DeleteAsync(id);
            return result;
        }

        public async Task<List<UserDto>> Get()
        {
            var result = await _repository.SelectAsync();
            var userDto = mapper.Map<List<UserDto>>(result);
            return userDto;
        }

        public async Task<UserDto> Get(Guid id)
        {
            var result = await _repository.SelectAsync(id);
            var userDto = mapper.Map<UserDto>(result);
            return userDto;
        }

        public async Task<UserCreateResultDto> Post(UserCreateDto user)
        {
            var userEntity = mapper.Map<UserEntity>(user);
            var result = await _repository.InsertAsync(userEntity);
            return mapper.Map<UserCreateResultDto>(result);
        }

        public async Task<UserUpdateResultDto> Put(UserUpdateDto user)
        {
            var userEntity = mapper.Map<UserEntity>(user);
            var result = await _repository.UpdateAsync(userEntity);
            return mapper.Map<UserUpdateResultDto>(result);
        }
    }
}
