using do_an_co_so.DataAccess;
using do_an_co_so.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace do_an_co_so.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tours = await _context.Tours.ToListAsync();
            return View(tours);
        }
        public async Task<IActionResult> Details(int id)
        {
            var tour = await _context.Tours
                .FirstOrDefaultAsync(m => m.MaTour == id);
            if (tour == null)
            {
                return NotFound();
            }
            return View(tour);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult DatTour()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
