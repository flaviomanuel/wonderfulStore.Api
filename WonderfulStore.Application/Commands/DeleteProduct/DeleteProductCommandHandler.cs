using MediatR;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Unit>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);

            if(product is null){
                throw new Exception("Produto não encontrado.");
            }  

            await _productRepository.DeleteAsync(product);
            
            return Unit.Value;
        }
    }
}