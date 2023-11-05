using Catalog.Application.Reponses;
using MediatR;

namespace Catalog.Application.Queries
{
    public class GetProductsByNameQuery : IRequest<List<ProductResponse>>
    {
        public string Name { get; set; }

        public GetProductsByNameQuery(string name)
        {
            Name = name;
        }
    }
}
