using do_an_co_so.Models;

namespace do_an_co_so.Repositories
{
    public interface IphuongthucthanhtoanRepository
    {
        Task<IEnumerable<PhuongThucThanhToan>> GetAllAsync();
        Task<PhuongThucThanhToan> GetByIdAsync(int id);
        Task AddAsync(PhuongThucThanhToan pttt);
        Task UpdateAsync(PhuongThucThanhToan pttt);
        Task DeleteAsync(int id);
    }
}
