using Catalog.Application.Commands;
using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;

        public UpdateProductHandler(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Id = request.Id,
                Name = request.Name,
                Summary = request.Summary,
                Description = request.Description,
                Brands = request.Brands,
                Price = request.Price,
                ImageFile = request.ImageFile,
                Types = request.Types,
            };

            var result = await _productRepository.UpdateProduct(product);
            return result;
        }
    }
}
