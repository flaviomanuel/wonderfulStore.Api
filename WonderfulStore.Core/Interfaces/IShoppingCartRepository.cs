using WonderfulStore.Core.Entities;

namespace WonderfulStore.Core.Interfaces
{
    public interface IShoppingCartRepository
    {
        Task<ShoppingCart> AddAsync(ShoppingCart shoppingCart);
        Task<ShoppingCart?> GetByIdAsync(Guid id);
    }
}