using MediatR;
using WonderfulStore.Core.Entities;

namespace WonderfulStore.Application.Commands.UpdateProductQuantityInShoppingCart
{
    public class UpdateProductQuantityInShoppingCartCommand : IRequest<ShoppingCartProduct>
    {
        public UpdateProductQuantityInShoppingCartCommand(Guid idProduct, Guid idShoppingCart, int quantity)
        {
            IdProduct = idProduct;
            IdShoppingCart = idShoppingCart;
            Quantity = quantity;
        }

        public Guid IdProduct { get; private set; }
        public Guid IdShoppingCart { get; private set; }
        public int Quantity { get; private set; }
    }
}