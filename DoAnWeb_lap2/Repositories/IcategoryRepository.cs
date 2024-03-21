using DoAnWeb_lap2.Models;

namespace DoAnWeb_lap2.Repositories
{
    public interface IcategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(int id);

    }
}
