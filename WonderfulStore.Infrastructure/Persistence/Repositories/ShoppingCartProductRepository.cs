using Microsoft.EntityFrameworkCore;
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

        public async Task<List<ShoppingCartProduct>> GetAllProductsFromShoppingCartById(Guid id)
        {
            var allProductsFromShoppingCard = await _context.ShoppingCartProducts
                    .Include(x => x.Product)
                    .Include(x => x.ShoppingCart)
                    .Where(x => x.IdShoppingCart == id)
                    .ToListAsync();

            return allProductsFromShoppingCard;
        }

        public async Task DeleteProductFromShoppingCartAsync(ShoppingCartProduct shoppingCartProduct){
            _context.ShoppingCartProducts.Remove(shoppingCartProduct);

           await _context.SaveChangesAsync();
        }

    }
}