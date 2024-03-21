using DoAnWeb_lap2.Models;

namespace DoAnWeb_lap2.Repositories
{
    public interface IproductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);

    }
}
