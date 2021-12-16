using AutoMapper;

namespace gRPCTest.Mapper
{
    public class AutoMapperFixture
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
