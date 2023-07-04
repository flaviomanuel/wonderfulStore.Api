using MediatR;
using WonderfulStore.Core.Entities;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Commands.UpdateProductQuantityInShoppingCart
{
    public class UpdateProductQuantityInShoppingCartCommandHandler : IRequestHandler<UpdateProductQuantityInShoppingCartCommand, ShoppingCartProduct>
    {
       private readonly IShoppingCartProductRepository _shoppingCartProductRepository;
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IPromotionServiceFactory _promotionServiceFactory;


        public UpdateProductQuantityInShoppingCartCommandHandler(
                IShoppingCartProductRepository shoppingCartProductRepository,
                IProductRepository productRepository,
                IShoppingCartRepository shoppingCartRepository,
                IPromotionServiceFactory promotionServiceFactory
            )
        {
            _shoppingCartProductRepository = shoppingCartProductRepository;
            _productRepository = productRepository;
            _shoppingCartRepository = shoppingCartRepository;
            _promotionServiceFactory = promotionServiceFactory;
        }

        public async Task<ShoppingCartProduct> Handle(UpdateProductQuantityInShoppingCartCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.IdProduct);

            if(product is null) throw new Exception("Produto nao encontrado.");

            var shoppingCart = await _shoppingCartRepository.GetByIdAsync(request.IdShoppingCart);

            if(shoppingCart is null) throw new Exception("Carrinho de compras nao encontrado.");

            var shoppingCartProduct = await _shoppingCartProductRepository.GetOneProductInShoppingCartAsync(product.Id, shoppingCart.Id);

            if(shoppingCartProduct is null) throw new Exception("O produto não está vinculado a este carrinho");

            shoppingCartProduct.UpdateQuantity(request.Quantity);

            var promotionService = _promotionServiceFactory.GetService(product.PromotionType);

            shoppingCartProduct.SetTotalPriceAccordingToPromotion(product.Price, promotionService);

            await _shoppingCartProductRepository.UpdateAsync(shoppingCartProduct);

            return shoppingCartProduct;
        }
    }
}