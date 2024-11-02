using AutoMapper;
using SecondHandBazar.Application.DTOs.Request;
using SecondHandBazar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandBazar.Infrastructure.Mapping
{
    public class CustomProfile : Profile
    {
        public CustomProfile()
        {
            CreateMap<ProductDto,Product>().ReverseMap();
        }
    }
}
