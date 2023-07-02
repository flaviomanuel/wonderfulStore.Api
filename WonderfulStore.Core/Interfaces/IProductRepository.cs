using WonderfulStore.Core.Entities;

namespace WonderfulStore.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> AddAsync(Product product);
        Task DeleteAsync(Product product);
        Task UpdateAsync(Product product);
        Task<Product?> GetByIdAsync(Guid id);
        Task<List<Product>> GetAllAsync();
    }
}