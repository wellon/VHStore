using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using VHStore.DTOs;
using VHStore.Models;

namespace VHStore.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // domain to DTO
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();


            // DTO to domain
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}