﻿using AutoMapper;
using Entities.Models;
using Shared;
using Shared.DTO;

namespace MotorcycleCompany
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Agency, AgencyDto>();
                //.ForCtorParam("FullDirection", opt => opt.MapFrom(x =>string.Join(' ', x.Address, x.Neighborhood)));
            CreateMap<Phone, PhoneDto>();
            CreateMap<Client, ClientDto>();   
            CreateMap<Garage, GarageDto>();
        }
    }
}
