using System.ComponentModel.DataAnnotations;

namespace do_an_co_so.Models
{
    public class Blog
    {
        [Key]public int Id { get; set; }
        public string Tieude { get; set; }
        public string Mota { get; set; }
        public string Noidung { get; set; }
        public string? Hinhanh { get; set; }
        public string Ngaydang { get; set; }
    }
}
