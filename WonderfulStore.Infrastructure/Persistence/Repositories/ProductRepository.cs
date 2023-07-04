using Microsoft.EntityFrameworkCore;
using WonderfulStore.Core.Entities;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product> AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);

            await _context.SaveChangesAsync();

           return product;
        }

        public async Task DeleteAsync(Product product)
        {
            _context.Products.Remove(product);

           await _context.SaveChangesAsync();
        }
        public async Task<List<Product>> GetAllAsync() => await _context.Products.ToListAsync();

        public async Task<Product?> GetByIdAsync(Guid id) => await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);

           await _context.SaveChangesAsync();
        }
    }
}