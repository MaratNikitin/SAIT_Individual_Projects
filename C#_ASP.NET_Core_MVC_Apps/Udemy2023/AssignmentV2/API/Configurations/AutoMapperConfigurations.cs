﻿using API.Models;
using API.Models.DTOs;
using AutoMapper;
using System.Diagnostics.Metrics;

namespace API.Configurations
{
    public class AutoMapperConfigurations : Profile
    {
        /// <summary>
        /// AutoMapper configurations (rules) are set in this constructor method
        /// </summary>
        public AutoMapperConfigurations()
        {
            CreateMap<Item, GetItemDTO>().ReverseMap();
            CreateMap<Item, CreateItemDTO>().ReverseMap();
            CreateMap<Item, UpdateItemDTO>().ReverseMap();
        }
    }
}
