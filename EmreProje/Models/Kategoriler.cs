using System.ComponentModel.DataAnnotations;

namespace EmreProje.Models
{
    public class Kategoriler
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Kategori Adı Giriniz!")]
        [StringLength(20, ErrorMessage = "Kategori Adı Adı 20 Karakter olmalıdır!")]
        public string KategoriAdi { get; set; }



        [Display(Name = "Urun Fiyat")]
        [Required(ErrorMessage = "Fiyat Giriniz!")]
        public decimal UrunFiyat { get; set; }


        [Display(Name = "Aktif")]
        public bool UrunAktif { get; set; }
    }
}
