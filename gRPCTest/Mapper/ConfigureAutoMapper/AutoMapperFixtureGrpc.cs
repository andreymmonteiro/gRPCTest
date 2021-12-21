using AutoMapper;
using gRPCTest.Mapper.Interface;
using System;

namespace gRPCTest.Mapper
{
    public class AutoMapperFixtureGrpc : IMapperGrpc
    {
        

        public IMapper GetMapper() 
        {
            var config = new MapperConfiguration(options => 
            {
                options.AddProfile(new DtoToProto());
            });
            return config.CreateMapper();
        }
    }
}
