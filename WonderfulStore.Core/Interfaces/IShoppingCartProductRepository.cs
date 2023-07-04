using WonderfulStore.Core.Entities;

namespace WonderfulStore.Core.Interfaces
{
    public interface IShoppingCartProductRepository
    {
        Task<ShoppingCartProduct> AddProductInShoppingCartAsync(ShoppingCartProduct shoppingCartProduct);
        Task<List<ShoppingCartProduct>> GetAllProductsFromShoppingCartById(Guid id);
        Task DeleteProductFromShoppingCartAsync(ShoppingCartProduct shoppingCartProduct);
        Task<ShoppingCartProduct?> GetOneProductInShoppingCartAsync(Guid idProduct, Guid idShoppingCart);
    }
}