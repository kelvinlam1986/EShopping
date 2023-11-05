using Catalog.Application.Reponses;
using MediatR;

namespace Catalog.Application.Queries
{
    public class GetProductsByBrandQuery : IRequest<List<ProductResponse>>
    {
        public string BrandName { get; set; }

        public GetProductsByBrandQuery(string brandName)
        {
            BrandName = brandName;
        }
    }
}
