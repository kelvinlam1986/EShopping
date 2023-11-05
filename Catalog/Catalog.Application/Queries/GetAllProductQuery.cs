using Catalog.Application.Reponses;
using MediatR;

namespace Catalog.Application.Queries
{
    public class GetAllProductQuery : IRequest<List<ProductResponse>>
    {
    }
}
