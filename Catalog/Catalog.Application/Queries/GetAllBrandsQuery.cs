using Catalog.Application.Reponses;
using MediatR;

namespace Catalog.Application.Queries
{
    public class GetAllBrandsQuery : IRequest<List<BrandResponse>>
    {
    }
}
