using do_an_co_so.Models;

namespace do_an_co_so.Repositories
{
    public interface IphuongthucthanhtoanRepository
    {
        Task<IEnumerable<Phuongthucthanhtoan>> GetAllAsync();
        Task<Phuongthucthanhtoan> GetByIdAsync(int id);
        Task AddAsync(Phuongthucthanhtoan pttt);
        Task UpdateAsync(Phuongthucthanhtoan pttt);
        Task DeleteAsync(int id);
    }
}
