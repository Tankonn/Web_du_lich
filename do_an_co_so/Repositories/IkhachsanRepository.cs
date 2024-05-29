using do_an_co_so.Models;

namespace do_an_co_so.Repositories
{
    public interface IkhachsanRepository
    {
        Task<IEnumerable<Khachsan>> GetAllAsync();
        Task<Khachsan> GetByIdAsync(int id);
        Task AddAsync(Khachsan khachsan);
        Task UpdateAsync(Khachsan khachsan);
        Task DeleteAsync(int id);
    }
}
