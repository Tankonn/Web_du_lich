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
            return await _context.datTours.Include(p => p.tour).ToListAsync();
        }

        public async Task<DatTour> GetByIdAsync(int id)
        {
            return await _context.datTours.Include(p => p.tour).FirstOrDefaultAsync(p => p.Matour == id);
        }

        public async Task AddAsync(DatTour datTour)
        {
            _context.datTours.Add(datTour);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(DatTour datTour)
        {
            _context.datTours.Update(datTour);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var datTour = await _context.datTours.FindAsync(id);
            _context.datTours.Remove(datTour);
            await _context.SaveChangesAsync();
        }
    }
}
