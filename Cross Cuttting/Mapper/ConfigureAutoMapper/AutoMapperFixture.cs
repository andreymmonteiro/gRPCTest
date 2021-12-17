using AutoMapper;
using Cross_Cuttting.Mapper.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross_Cuttting.Mapper.ConfigureAutoMapper
{
    public class AutoMapperFixture : IMapperService, IDisposable 
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public IMapper GetMapper() 
        {
            var config = new AutoMapper.MapperConfiguration(map => 
            {
                map.AddProfile(new DtoToModelProfile());
                map.AddProfile(new EntityToDtoProfile());
                map.AddProfile(new ModelToEntityProfile());
            });
            return config.CreateMapper();
        } 
    }
}
