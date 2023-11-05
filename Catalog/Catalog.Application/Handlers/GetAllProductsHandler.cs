using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Reponses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductQuery, List<ProductResponse>>
    {
        private readonly IProductRepository _repository;

        public GetAllProductsHandler(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository)); 
        }

        public async Task<List<ProductResponse>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var products = await _repository.GetProducts();
            var results = ProductMapper.Mapper.Map<List<ProductResponse>>(products.ToList());
            return results;
        }
    }
}
