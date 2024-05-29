using Microsoft.EntityFrameworkCore;
using do_an_co_so.DataAccess;
using do_an_co_so.Models;

namespace do_an_co_so.Repositories
{
    public class EFkhachsanRepository : IkhachsanRepository
    {
        private readonly ApplicationDbContext _context;
        public EFkhachsanRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Khachsan>> GetAllAsync()
        {
            return await _context.Khachsans.Include(p => p.Tours).ToListAsync();
        }

        public async Task<Khachsan> GetByIdAsync(int id)
        {
            return await _context.Khachsans.Include(p => p.Tours).FirstOrDefaultAsync(p => p.Makhachsan == id);
        }

        public async Task AddAsync(Khachsan khachSan)
        {
            _context.Khachsans.Add(khachSan);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Khachsan khachSan)
        {
            _context.Khachsans.Update(khachSan);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var khachSan = await _context.Khachsans.FindAsync(id);
            _context.Khachsans.Remove(khachSan);
            await _context.SaveChangesAsync();
        }
    }
}
