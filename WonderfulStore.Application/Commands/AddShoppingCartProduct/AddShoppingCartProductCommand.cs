using MediatR;
using WonderfulStore.Application.ViewModels;
using WonderfulStore.Core.Entities;

namespace WonderfulStore.Application.Commands.AddShoppingCartProduct
{
    public class AddShoppingCartProductCommand : IRequest<AddShoppingCartProductViewModel>
    {
        public Guid IdProduct { get; set; }
        public Guid IdShoppingCart { get; set; }
        public int Quantity { get; set; }
    }
}