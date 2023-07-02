using WonderfulStore.Core.Entities;

namespace WonderfulStore.Core.Interfaces
{
    public interface IShoppingCartProductRepository
    {
        Task<ShoppingCartProduct> AddProductInShoppingCartAsync(ShoppingCartProduct shoppingCartProduct);
    }
}