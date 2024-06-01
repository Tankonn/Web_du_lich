using do_an_co_so.DataAccess;
using do_an_co_so.Models;
using do_an_co_so.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace do_an_co_so.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TourController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ItourRepository _tourRepository;
        private readonly IdattourRepository _dattourRepository;

        public TourController(ItourRepository tourRepository, IdattourRepository dattourRepository, ApplicationDbContext context)
        {
            _context = context;
            _tourRepository = tourRepository;
            _dattourRepository = dattourRepository;
        }
        public async Task<IActionResult> Index()
        {
            var Tours = await _tourRepository.GetAllAsync();
            return View(Tours);
        }
        public async Task<IActionResult> Details(int id)
        {
            var Tours = await _tourRepository.GetByIdAsync(id);
            if (Tours == null)
            {
                return NotFound();
            }
            return View(Tours);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Tour tours)
        {
            if (ModelState.IsValid)
            {
                await _tourRepository.AddAsync(tours);
                return RedirectToAction(nameof(Index));
            }
            return View(tours);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var tours = await _tourRepository.GetByIdAsync(id);
            if (tours == null)
            {
                return NotFound();
            }
            return View(tours);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Tour tours)
        {
            if (id != tours.MaTour)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingTour = await _tourRepository.GetByIdAsync(id);
                // Cập nhật các thông tin khác của sản phẩm
                existingTour.TenTour = tours.TenTour;
                existingTour.Mota = tours.Mota;
                existingTour.Thongtinlienquan = tours.Thongtinlienquan;
                existingTour.Banggia = tours.Banggia;
                existingTour.Thoiluong = tours.Thoiluong;
                existingTour.Diadiemkhoihanh = tours.Diadiemkhoihanh;
                existingTour.Diemden = tours.Diemden;
                existingTour.Images = tours.Images;
                existingTour.Lichtrinh = tours.Lichtrinh;
                existingTour.Tinhtrang = tours.Tinhtrang;
                await _tourRepository.UpdateAsync(existingTour);

                return RedirectToAction(nameof(Index));
            }
            return View(tours);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var tours = await _tourRepository.GetByIdAsync(id);
            if (tours == null)
            {
                return NotFound();
            }
            return View(tours);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _tourRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
