using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Reponses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetAllTypesHandler : IRequestHandler<GetAllTypesQuery, List<TypesResponse>>
    {
        private readonly ITypeRepository _typeRepository;

        public GetAllTypesHandler(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }

        public async Task<List<TypesResponse>> Handle(GetAllTypesQuery request, CancellationToken cancellationToken)
        {
            var types = await _typeRepository.GetAllTypes();
            var results = ProductMapper.Mapper.Map<List<TypesResponse>>(types.ToList());
            return results;
        }
    }
}
