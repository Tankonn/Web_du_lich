using do_an_co_so.DataAccess;
using do_an_co_so.Models;
using do_an_co_so.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace do_an_co_so.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KhachsanController : Controller
    {
        
        private readonly IkhachsanRepository _khachsanRepository;

        public KhachsanController(IkhachsanRepository khachsanRepository)
        {
            
            _khachsanRepository = khachsanRepository;
            
        }
        public async Task<IActionResult> Index()
        {
            var Khachsans = await _khachsanRepository.GetAllAsync();
            return View(Khachsans);
        }
        public async Task<IActionResult> Details(int id)
        {
            var Khachsans = await _khachsanRepository.GetByIdAsync(id);
            if (Khachsans == null)
            {
                return NotFound();
            }
            return View(Khachsans);
        }
        public async Task<IActionResult> Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Tour tours, IFormFile anh)
        {
            if (ModelState.IsValid)
            {
                if (anh != null)
                {
                    tours.Images = await SaveImage(anh);
                }
                await _khachsanRepository.AddAsync(Khachsans);
                return RedirectToAction(nameof(Index));
            }
            var khachSans = await _khachsanRepository.GetAllAsync();
            ViewBag.khachSans = new SelectList(khachSans, "Makhachsan", "Tenkhachsan");
            return View(tours);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var tours = await _khachsanRepository.GetByIdAsync(id);
            if (tours == null)
            {
                return NotFound();
            }
            var khachSans = await _khachsanRepository.GetAllAsync();
            ViewBag.khachSans = new SelectList(khachSans, "Makhachsan", "Tenkhachsan");
            return View(tours);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Tour tours, IFormFile anh)
        {
            if (id != tours.MaTour)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                var existingTour = await _khachsanRepository.GetByIdAsync(id);
                // Giữ nguyên thông tin hình ảnh nếu không có hình mới được tải lên            
                if (anh == null)
                {
                    tours.Images = existingTour.Images;
                }
                else
                {
                    // Lưu hình ảnh mới
                    tours.Images = await SaveImage(anh);
                }
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
                await _khachsanRepository.UpdateAsync(existingTour);

                return RedirectToAction(nameof(Index));
            }
            var khachSans = await _khachsanRepository.GetAllAsync();
            ViewBag.khachSans = new SelectList(khachSans, "Makhachsan", "Tenkhachsan");
            return View(tours);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var tours = await _khachsanRepository.GetByIdAsync(id);
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
            await _khachsanRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
        private async Task<string> SaveImage(IFormFile image)
        {
            var savePath = Path.Combine("wwwroot/style/img", image.FileName); // Thay   đổi đường dẫn theo cấu hình của bạn
            using (var fileStream = new FileStream(savePath, FileMode.Create))
            {
                await image.CopyToAsync(fileStream);
            }
            return "style/img" + image.FileName; // Trả về đường dẫn tương đối
        }
    }
}
