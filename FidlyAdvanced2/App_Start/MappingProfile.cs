using AutoMapper;
using FidlyAdvanced2.Dto;
using FidlyAdvanced2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FidlyAdvanced2.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MovieDto, Movie>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
        }
    }
}