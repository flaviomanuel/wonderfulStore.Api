using MediatR;
using WonderfulStore.Core.Entities;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Commands.GetByIdProduct
{
    public class GetByIdProductCommandHandler : IRequestHandler<GetByIdCommand, Product>
    {
        private readonly IProductRepository _productRepository;

        public GetByIdProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Product> Handle(GetByIdCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);

            if (product is null) throw new Exception("Produto não encontrado");

            return product;
        }
    }
}