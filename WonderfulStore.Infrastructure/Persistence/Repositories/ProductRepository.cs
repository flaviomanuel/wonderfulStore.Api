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

        public async Task<Product> Add(Product product)
        {
           await _context.AddAsync(product);

           return product;
        }

        public async Task Delete(Product product)
        {
            _context.Remove(product);

           await _context.SaveChangesAsync();
        }
        public async Task<List<Product>> GetAll() =>  await _context.Products.ToListAsync();

        public async Task<Product?> GetById(Guid id) => await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

        public async Task Update(Product product)
        {
            _context.Products.Update(product);

           await _context.SaveChangesAsync();
        }
    }
}