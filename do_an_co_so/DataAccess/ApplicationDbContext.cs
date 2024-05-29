using do_an_co_so.Models;
using Microsoft.EntityFrameworkCore;
using do_an_co_so.Models;

namespace do_an_co_so.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Khachsan> Khachsans { get; set; }
        public DbSet<Phuongthucthanhtoan> phuongthucthanhtoans { get; set; }
        public DbSet<DatTour> datTours { get; set; }

    }
}
