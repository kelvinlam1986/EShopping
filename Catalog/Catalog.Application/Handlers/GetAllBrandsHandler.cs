using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Reponses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetAllBrandsHandler : IRequestHandler<GetAllBrandsQuery, List<BrandResponse>>
    {
        private readonly IBrandRepository _brandRepository;
        public GetAllBrandsHandler(
            IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<List<BrandResponse>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            var brands = await _brandRepository.GetAllBrands();
            var result = ProductMapper.Mapper.Map<List<BrandResponse>>(brands.ToList());
            return result;
        }
    }
}
