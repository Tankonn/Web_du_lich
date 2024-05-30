using System.ComponentModel.DataAnnotations;

namespace do_an_co_so.Models
{
    public class Tour
    {
        [Key]public int MaTour { get; set; }
        public string TenTour { get; set; }
        public string Mota { get; set; }
        public string Lichtrinh { get; set; }
        public string Banggia { get; set; }
        public string Thongtinlienquan { get; set; }
        public string Images { get; set; }
        public int Tinhtrang { get; set; }
        public int Diadiemkhoihanh { get; set; }
        public string Thoiluong { get; set; }
        public string Diemden { get; set; }
    }
}
