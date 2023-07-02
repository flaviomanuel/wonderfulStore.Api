using WonderfulStore.Core.Entities;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Infrastructure.Persistence.Repositories
{
    public class ShoppingCartProductRepository : IShoppingCartProductRepository
    {
        private readonly AppDbContext _context;

        public ShoppingCartProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ShoppingCartProduct> AddProductInShoppingCartAsync(ShoppingCartProduct shoppingCartProduct)
        {
            await _context.ShoppingCartProducts.AddAsync(shoppingCartProduct);

            await _context.SaveChangesAsync();

            return shoppingCartProduct;
        }

    }
}