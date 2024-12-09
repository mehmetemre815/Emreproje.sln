using System.ComponentModel.DataAnnotations;

namespace EmreProje.Models
{
    public class Sepet
    {
        [Key]
        public int SepetID { get; set; }

        public int UrunID { get; set; }

        public string UrunAdet { get; set; }

        public decimal Toplam_Fiyat { get; set; }
    }
}
