using Microsoft.EntityFrameworkCore;
using do_an_co_so.DataAccess;
using do_an_co_so.Models;


namespace do_an_co_so.Repositories
{
    public class EFtourRepository : ItourRepository
    {
        private readonly ApplicationDbContext _context;
        public EFtourRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Tour>> GetAllAsync()
        {
            //return await _context.Tours.ToListAsync();
            return await _context.Tours.Include(p => p.MaTour).ToListAsync();
        }

        public async Task<Tour> GetByIdAsync(int id)
        {
            return await _context.Tours.Include(p => p.MaTour).FirstOrDefaultAsync(p => p.MaTour == id);
        }

        public async Task AddAsync(Tour Tour)
        {
            _context.Tours.Add(Tour);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Tour Tour)
        {
            _context.Tours.Update(Tour);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var Tour = await _context.Tours.FindAsync(id);
            _context.Tours.Remove(Tour);
            await _context.SaveChangesAsync();
        }
    }
}
