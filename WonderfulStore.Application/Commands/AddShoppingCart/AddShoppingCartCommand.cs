using MediatR;

namespace WonderfulStore.Application.Commands.AddShoppingCart
{
    public class AddShoppingCartCommand : IRequest<Guid>
    {
    }
}