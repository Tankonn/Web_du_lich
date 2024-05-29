using System.ComponentModel.DataAnnotations;

namespace do_an_co_so.Models
{
    public class Phuongthucthanhtoan
    {
        [Key]
        public int Mapt {  get; set; }
        public string Tenpt {  get; set; }
        public DatTour DatTour { get; set; }

    }
}
