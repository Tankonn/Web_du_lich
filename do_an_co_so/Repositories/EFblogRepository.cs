using Microsoft.EntityFrameworkCore;
using do_an_co_so.DataAccess;
using do_an_co_so.Models;

namespace do_an_co_so.Repositories
{
    public class EFblogRepository : IblogRepository
    {
        private readonly ApplicationDbContext _context;
        public EFblogRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Blog>> GetAllAsync()
        {
            return await _context.Blogs.ToListAsync();
            //return await _context.Blogs.Include(p => p.).ToListAsync();
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await _context.Blogs.FindAsync();
            //return await _context.Blogs.Include(p => p.).FirstOrDefaultAsync(p => p.ChuongTruyenId == id);
        }
        public async Task AddAsync(Blog Blog)
        {
            _context.Blogs.Add(Blog);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Blog Blog)
        {
            _context.Blogs.Update(Blog);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var Blog = await _context.Blogs.FindAsync(id);
            _context.Blogs.Remove(Blog);
            await _context.SaveChangesAsync();
        }
    }
}
