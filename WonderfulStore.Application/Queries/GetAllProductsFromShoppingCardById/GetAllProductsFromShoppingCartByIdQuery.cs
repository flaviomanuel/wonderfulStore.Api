using MediatR;
using WonderfulStore.Application.ViewModels;
using WonderfulStore.Core.Entities;

namespace WonderfulStore.Application.Queries.GetAllProductsFromShoppingCardById
{
    public class GetAllProductsFromShoppingCartByIdQuery : IRequest<List<ProductsFromShoppingCartViewModel>>
    {
        public Guid IdShoppingCart { get; set; }
    }
}