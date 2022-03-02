using AutoMapper;
using Domain.Dtos.User;
using Domain.Services.User;
using Grpc.Core;
using gRPCTest.Mapper.Interface;
using gRPCTest.Protos;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace gRPCTest.Services
{
    [Authorize]
    public class UserService : User.UserBase 
    {
        private readonly IUserService service;
        private readonly IMapper mapper;
        public UserService(IUserService service, IMapperGrpc mapper)
        {
            this.service = service;
            this.mapper = mapper.GetMapper();
        }

        public override async Task<UserProDto> Get(GetUserRequest request, ServerCallContext context)
        {
            Guid id = new Guid(request.Id);
            var result = await service.Get(id);
            var userProto = mapper.Map<UserProDto>(result);
            return userProto;
        }

        public override async Task<UserCreateResultProtoDto> Post(CreateUserRequest request, ServerCallContext context)
        {
            UserCreateDto userCreateDto = mapper.Map<UserCreateDto>(request);
            var result = await service.Post(userCreateDto);
            return mapper.Map<UserCreateResultProtoDto>(result);
        }

        public override async Task<DeleteUserResponse> Delete(DeleteUserRequest request, ServerCallContext context)
        {
            Guid id = new Guid(request.Id);
            var result = await service.Delete(id);
            return new DeleteUserResponse() { Success = result };
        }

        public override async Task<UserUpdateResultProtoDto> Put(UpdateUserRequest request, ServerCallContext context)
        {
            var userUpdateDto = mapper.Map<UserUpdateDto>(request);
            var result = await service.Put(userUpdateDto);

            return mapper.Map<UserUpdateResultProtoDto>(result);
        }

        public override async Task<ListUserProDto> GetAll(GetAttUserRequest request, ServerCallContext context)
        {
            var result = await service.Get();
            ListUserProDto listUsersProDto = new ListUserProDto();
            listUsersProDto.UsersProDto.Add(result.Select(s => mapper.Map<UserProDto>(s)).ToList());
            
            return listUsersProDto;
        }
    }                                           
}                           
