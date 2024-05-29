using System.ComponentModel.DataAnnotations;

namespace do_an_co_so.Models
{
    public class DatTour
    {
        [Key]
        public string IdDattour { get; set; }
        public string? TenKh { get; set; }
        public string sdt { get; set; }
        public string? email { get; set; }
        public string? diachi { get; set; }
        public int? Mapt { get; set; }
        public string? yeucau { get; set; }
        public int? Matour { get; set; }
        public int? Tinhtrang { get; set; }
        public Khachsan Makhachsan { get; set; }
        public Tour tour { get; set; }
        public List<Phuongthucthanhtoan> phuongthucthanhtoan { get; set; }

    }
}
