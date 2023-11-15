using AutoMapper;
using Catalog.Application.Commands;
using Catalog.Application.Reponses;
using Catalog.Core.Entities;

namespace Catalog.Application.Mappers
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile() 
        {
            CreateMap<ProductBrand, BrandResponse>();
            CreateMap<Product, ProductResponse>();
            CreateMap<ProductType, TypesResponse>();
            CreateMap<CreateProductCommand, Product>();
        }
    }
}
