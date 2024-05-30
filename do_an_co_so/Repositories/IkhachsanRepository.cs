using do_an_co_so.Models;

namespace do_an_co_so.Repositories
{
    public interface IkhachsanRepository
    {
        Task<IEnumerable<KhachSan>> GetAllAsync();
        Task<KhachSan> GetByIdAsync(int id);
        Task AddAsync(KhachSan khachsan);
        Task UpdateAsync(KhachSan khachsan);
        Task DeleteAsync(int id);
    }
}
