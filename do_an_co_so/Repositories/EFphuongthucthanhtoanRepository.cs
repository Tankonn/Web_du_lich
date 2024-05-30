
using Microsoft.EntityFrameworkCore;
using do_an_co_so.DataAccess;
using do_an_co_so.Models;

namespace do_an_co_so.Repositories
{
    public class EFphuongthucthanhtoanRepository : IphuongthucthanhtoanRepository
    {
        private readonly ApplicationDbContext _context;
        public EFphuongthucthanhtoanRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<PhuongThucThanhToan>> GetAllAsync()
        {
            return await _context.Phuongthucthanhtoans.Include(p => p.DatTour).ToListAsync();
        }

        public async Task<PhuongThucThanhToan> GetByIdAsync(int id)
        {
            return await _context.Phuongthucthanhtoans.Include(p => p.DatTour).FirstOrDefaultAsync(p => p.Mapt == id);
        }

        public async Task AddAsync(PhuongThucThanhToan phuongthucthanhtoan)
        {
            _context.Phuongthucthanhtoans.Add(phuongthucthanhtoan);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(PhuongThucThanhToan phuongthucthanhtoan)
        {
            _context.Phuongthucthanhtoans.Update(phuongthucthanhtoan);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var phuongthucthanhtoan = await _context.Phuongthucthanhtoans.FindAsync(id);
            _context.Phuongthucthanhtoans.Remove(phuongthucthanhtoan);
            await _context.SaveChangesAsync();
        }
    }
}
