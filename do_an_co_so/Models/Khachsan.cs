using System.ComponentModel.DataAnnotations;

namespace do_an_co_so.Models
{
    public class Khachsan
    {
        [Key]
        public string Makhachsan { get; set; }
        public string Tenkhachsan { get; set; }
        public string Diachi { get; set; }
        public string Dongia { get; set; }
        public string images { get; set; }
        public int Tinhtrang { get; set; }
        public string Mota { get; set; }   
        public string Thongtinchitiet {  get; set; }

    }
}
