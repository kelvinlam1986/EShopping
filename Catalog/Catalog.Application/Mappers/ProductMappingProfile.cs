﻿using AutoMapper;
using Catalog.Application.Reponses;
using Catalog.Core.Entities;

namespace Catalog.Application.Mappers
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile() 
        {
            CreateMap<ProductBrand, BrandResponse>();
        }
    }
}
