﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleMono.Models;
using VehicleMono.Models.Common;
using VehicleMono.WebAPI.ViewModels;

namespace VehicleMono.WebAPI.App_Start
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<VehicleMake, VehicleMakeVM>().ReverseMap();
            CreateMap<IVehicleMake, VehicleMakeVM>().ReverseMap();

            CreateMap<VehicleModel, VehicleModelVM>().ReverseMap();
            CreateMap<IVehicleModel, VehicleModelVM>().ReverseMap();
        }
    }
}