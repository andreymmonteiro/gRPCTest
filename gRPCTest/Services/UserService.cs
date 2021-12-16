using AutoMapper;
using Domain.Services.User;
using Grpc.Core;
using gRPCTest.Protos;
using System;
using System.Threading.Tasks;

namespace gRPCTest.Services
{
    public class UserService : User.UserBase 
    {
        private readonly IUserService service;
        private readonly IMapper mapper;
        public UserService(IUserService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        public override async Task<UserProDto> Get(GetUserRequest request, ServerCallContext context)
        {
            Guid id = new Guid(request.Id);
            var result = await service.Get(id);

            return mapper.Map<UserProDto>(result);

            //return base.Get(request, context);
        }
    }
}
