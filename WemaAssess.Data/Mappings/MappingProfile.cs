using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WemaAssess.Data.Dtos;
using WemaAssess.Infrastructure.Data;

namespace WemaAssess.Data.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerDto, Customer>().ReverseMap();
        }
    }
}
