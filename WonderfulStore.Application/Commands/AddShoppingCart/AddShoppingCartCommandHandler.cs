using MediatR;
using WonderfulStore.Core.Entities;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Commands.AddShoppingCart
{
    public class AddShoppingCartCommandHandler : IRequestHandler<AddShoppingCartCommand, Guid>
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        public AddShoppingCartCommandHandler(IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }
        public async Task<Guid> Handle(AddShoppingCartCommand request, CancellationToken cancellationToken)
        {
            var shoppingCart = new ShoppingCart();

            await _shoppingCartRepository.AddAsync(shoppingCart);
            
            return shoppingCart.Id;
        }
    }
}