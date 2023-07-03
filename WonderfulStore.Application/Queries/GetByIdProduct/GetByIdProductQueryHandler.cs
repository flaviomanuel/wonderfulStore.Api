using MediatR;
using WonderfulStore.Application.ViewModels;
using WonderfulStore.Core.Entities;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Commands.GetByIdProduct
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQuery, ProductViewModel>
    {
        private readonly IProductRepository _productRepository;

        public GetByIdProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<ProductViewModel> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);

            if (product is null) throw new Exception("Produto não encontrado");

            var productViewModel = new ProductViewModel(product.Id, product.Name, product.Price, product.Description, product.PromotionType);
         
            return productViewModel;
        }
    }
}