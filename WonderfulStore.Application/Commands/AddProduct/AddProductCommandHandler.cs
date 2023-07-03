using MediatR;
using WonderfulStore.Core.Entities;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Commands.AddProduct
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Guid>
    {
        private readonly IProductRepository _productRepository;

        public AddProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Guid> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price, request.Description, request.PromotionType);

            await _productRepository.AddAsync(product);

            return product.Id;
        }
    }
}