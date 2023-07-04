using MediatR;
using WonderfulStore.Application.Commands.AddShoppingCartProduct.Builder;
using WonderfulStore.Application.ViewModels;
using WonderfulStore.Core.Entities;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Commands.AddShoppingCartProduct
{
    public class AddShoppingCartProductCommandHandler : IRequestHandler<AddShoppingCartProductCommand, AddShoppingCartProductViewModel>
    {
        private readonly IShoppingCartProductRepository _shoppingCartProductRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IProductRepository _productRepository;
        private readonly IPromotionServiceFactory _promotionServiceFactory;

        private IPromotionService _promotionService;
        public AddShoppingCartProductCommandHandler(
                        IShoppingCartProductRepository shoppingCartProductRepository, 
                        IShoppingCartRepository shoppingCartRepository, 
                        IProductRepository productRepository, 
                        IPromotionServiceFactory promotionServiceFactory
            )
        {
            _shoppingCartProductRepository = shoppingCartProductRepository;
            _shoppingCartRepository = shoppingCartRepository;
            _productRepository = productRepository;
            _promotionServiceFactory = promotionServiceFactory;
        }
        public async Task<AddShoppingCartProductViewModel> Handle(AddShoppingCartProductCommand request, CancellationToken cancellationToken)
        {
            var shoppingCart = await _shoppingCartRepository.GetByIdAsync(request.IdShoppingCart);

            if(shoppingCart is null) throw new Exception("Carrinho de compras nao encontrado.");

            var product = await _productRepository.GetByIdAsync(request.IdProduct);

            if(product is null) throw new Exception("Produto nao encontrado.");

            var promotionService = _promotionServiceFactory.GetService(product.PromotionType);
    
            var shoppingCartProduct = new ShoppingCartProduct(request.Quantity, product.Price, promotionService , product.Id, shoppingCart.Id);

            await _shoppingCartProductRepository.AddProductInShoppingCartAsync(shoppingCartProduct);

            var builder = new AddShoppingCartProductViewModelBuilder();

            var addShoppingCartProductViewModelBuilder = builder
                        .Start()
                        .WithFundamentalInfos(request.Quantity)
                        .WithProductViewModel(new ProductViewModel(product.Id, product.Name, product.Price, product.Description, product.PromotionType))
                        .WithShoppingCartViewModel(new ShoppingCartViewModel(shoppingCart.Id, shoppingCart.Status))
                        .Build();
        
            return addShoppingCartProductViewModelBuilder;
        }
    }
}