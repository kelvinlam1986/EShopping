using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Reponses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetProductsByBrandHandler : IRequestHandler<GetProductsByBrandQuery, List<ProductResponse>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductsByBrandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductResponse>> Handle(GetProductsByBrandQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetProductsByBrand(request.BrandName);
            var results = ProductMapper.Mapper.Map<List<ProductResponse>>(products.ToList());
            return results;
        }
    }
}
