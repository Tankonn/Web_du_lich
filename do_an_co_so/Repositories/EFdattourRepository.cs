using Microsoft.EntityFrameworkCore;
using do_an_co_so.DataAccess;
using do_an_co_so.Models;

namespace do_an_co_so.Repositories
{
    public class EFdattourRepository : IdattourRepository
    {
        private readonly ApplicationDbContext _context;
        public EFdattourRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<DatTour>> GetAllAsync()
        {
            return await _context.DatTours.Include(p => p.Tour).ToListAsync();
        }

        public async Task<DatTour> GetByIdAsync(int id)
        {
            return await _context.DatTours.Include(p => p.Tour).FirstOrDefaultAsync(p => p.Matour == id);
        }

        public async Task AddAsync(DatTour datTour)
        {
            _context.DatTours.Add(datTour);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(DatTour datTour)
        {
            _context.DatTours.Update(datTour);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var datTour = await _context.DatTours.FindAsync(id);
            _context.DatTours.Remove(datTour);
            await _context.SaveChangesAsync();
        }
    }
}
