using System.ComponentModel.DataAnnotations;

namespace do_an_co_so.Models
{
    public class DatTour
    {
        [Key] public int? IdDattour { get; set; }
        public string TenKh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Diachi { get; set; }
        public int? Mapt { get; set; }
        public string Yeucau { get; set; }
        public int? Matour { get; set; }
        public int? Tinhtrang { get; set; }

        public int? Makhachsan { get; set; }
        public KhachSan Khachsan { get; set; }
        public Tour Tour { get; set; }
        public List<PhuongThucThanhToan> Phuongthucthanhtoan { get; set; }
    }
}
