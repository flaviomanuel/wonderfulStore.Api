using WonderfulStore.Core.Entities;

namespace WonderfulStore.Core.Interfaces
{
    public interface IShoppingCartRepository
    {
        Task<ShoppingCart> Add(ShoppingCart shoppingCart);
    }
}