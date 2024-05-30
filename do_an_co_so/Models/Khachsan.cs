using System.ComponentModel.DataAnnotations;

namespace do_an_co_so.Models
{
    public class KhachSan
    {
        [Key]public int Makhachsan { get; set; }
        public string Tenkhachsan { get; set; }
        public string Diachi { get; set; }
        public string Dongia { get; set; }
        public string Images { get; set; }
        public int Tinhtrang { get; set; }
        public string Mota { get; set; }
        public string Thongtinchitiet { get; set; }

        public List<Tour> Tours { get; set; }
    }
}
