using AutoMapper;
using Domain.Mapper.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mapper.ConfigureAutoMapper
{
    public class AutoMapperFixture : IMapperService
    {
        
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
