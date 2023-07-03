using MediatR;
using WonderfulStore.Application.Queries.GetAllProductsFromShoppingCardById.Builder;
using WonderfulStore.Application.ViewModels;
using WonderfulStore.Core.Entities;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Queries.GetAllProductsFromShoppingCardById
{
    public class GetAllProductsFromShoppingCartByIdQueryHandler : IRequestHandler<GetAllProductsFromShoppingCartByIdQuery, List<ProductsFromShoppingCartViewModel>>
    {
        private readonly IShoppingCartProductRepository _shoppingCartProductRepository;

        public GetAllProductsFromShoppingCartByIdQueryHandler(IShoppingCartProductRepository shoppingCartProductRepository)
        {
            _shoppingCartProductRepository = shoppingCartProductRepository;
        }

        public async Task<List<ProductsFromShoppingCartViewModel>> Handle(GetAllProductsFromShoppingCartByIdQuery request, CancellationToken cancellationToken)
        {
            var allProductsFromShoppingCard = await _shoppingCartProductRepository.GetAllProductsFromShoppingCartById(request.IdShoppingCart);
        
            var builder = new  ProductsFromShoppingCartViewModelBuilder();

            var listProductsFromShoppingCartViewModels = allProductsFromShoppingCard
                            .Select(x => 
                                    builder
                                    .Start()
                                    .WithFundamentalsInfos(x.Quantity, x.TotalPrice)
                                    .WithProduct(
                                        new ProductViewModel(
                                                x.IdProduct, 
                                                x.Product.Name,
                                                x.Product.Price,
                                                x.Product.Description,
                                                x.Product.PromotionType
                                            ))
                                    .Build()
                                    )
                                    .ToList();

            return listProductsFromShoppingCartViewModels;
        }
    }
}