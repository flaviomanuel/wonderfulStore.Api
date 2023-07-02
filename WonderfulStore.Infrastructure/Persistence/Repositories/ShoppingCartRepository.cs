using Microsoft.EntityFrameworkCore;
using WonderfulStore.Core.Entities;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Infrastructure.Persistence.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly AppDbContext _context;

        public ShoppingCartRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ShoppingCart> AddAsync(ShoppingCart shoppingCart)
        {  
            await _context.ShoppingCarts.AddAsync(shoppingCart);

            await _context.SaveChangesAsync();

           return shoppingCart;
        }

        public async Task<ShoppingCart?> GetByIdAsync(Guid id) => await _context.ShoppingCarts.FirstOrDefaultAsync(x => x.Id == id);
        
    }
}