
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
        public async Task<IEnumerable<Phuongthucthanhtoan>> GetAllAsync()
        {
            return await _context.phuongthucthanhtoans.Include(p => p.DatTour).ToListAsync();
        }

        public async Task<Phuongthucthanhtoan> GetByIdAsync(int id)
        {
            return await _context.phuongthucthanhtoans.Include(p => p.DatTour).FirstOrDefaultAsync(p => p.Mapt == id);
        }

        public async Task AddAsync(Phuongthucthanhtoan phuongthucthanhtoan)
        {
            _context.phuongthucthanhtoans.Add(phuongthucthanhtoan);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Phuongthucthanhtoan phuongthucthanhtoan)
        {
            _context.phuongthucthanhtoans.Update(phuongthucthanhtoan);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var phuongthucthanhtoan = await _context.phuongthucthanhtoans.FindAsync(id);
            _context.phuongthucthanhtoans.Remove(phuongthucthanhtoan);
            await _context.SaveChangesAsync();
        }
    }
}
