using MediatR;
using WonderfulStore.Application.ViewModels;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductViewModel>>
    {
        private readonly IProductRepository _productRepository;

        public GetAllProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<ProductViewModel>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync();

            var productViewModels = products.Select(x => new ProductViewModel(x.Id, x.Name, x.Price, x.Description, x.PromotionType)).ToList();
        
            return productViewModels;
        }
    }
}