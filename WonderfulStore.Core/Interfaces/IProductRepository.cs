using WonderfulStore.Core.Entities;

namespace WonderfulStore.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> Add(Product product);
        Task Delete(Product product);
        Task Update(Product product);
        Task<Product?> GetById(Guid id);
        Task<List<Product>> GetAll();
    }
}