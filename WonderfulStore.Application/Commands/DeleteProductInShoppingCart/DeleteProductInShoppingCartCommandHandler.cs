using MediatR;
using WonderfulStore.Core.Entities;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Commands.DeleteProductInShoppingCart
{
    public class DeleteProductInShoppingCartCommandHandler : IRequestHandler<DeleteProductInShoppingCartCommand, Unit>
    {
        private readonly IShoppingCartProductRepository _shoppingCartProductRepository;
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public DeleteProductInShoppingCartCommandHandler(
            IShoppingCartProductRepository shoppingCartProductRepository, 
            IProductRepository productRepository, 
            IShoppingCartRepository shoppingCartRepository
        )
        {
            _shoppingCartProductRepository = shoppingCartProductRepository;
            _productRepository = productRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }


        public async Task<Unit> Handle(DeleteProductInShoppingCartCommand request, CancellationToken cancellationToken)
        {
            
            var product = await _productRepository.GetByIdAsync(request.IdProduct);

            if(product is null) throw new Exception("Produto nao encontrado.");

            var shoppingCart = await _shoppingCartRepository.GetByIdAsync(request.IdShoppingCart);

            if(shoppingCart is null) throw new Exception("Carrinho de compras nao encontrado.");

           var shoppingCartProduct = await _shoppingCartProductRepository.GetOneProductInShoppingCartAsync(product.Id, shoppingCart.Id);

            if(shoppingCartProduct is null) throw new Exception("O produto não está vinculado a este carrinho");

            await _shoppingCartProductRepository.DeleteProductFromShoppingCartAsync(shoppingCartProduct);

            return Unit.Value;
        }
    }
}