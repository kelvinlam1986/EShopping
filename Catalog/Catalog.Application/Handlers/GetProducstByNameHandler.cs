using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Reponses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetProducstByNameHandler : IRequestHandler<GetProductsByNameQuery, List<ProductResponse>>
    {
        private readonly IProductRepository _productRepository;

        public GetProducstByNameHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductResponse>> Handle(GetProductsByNameQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetProductsByName(request.Name);
            var results = ProductMapper.Mapper.Map<List<ProductResponse>>(products.ToList());
            return results;
        }
    }
}
