using System.ComponentModel.DataAnnotations;

namespace EmreProje.Models
{
    public class UrunListele
    {

        [Display(Name = "Urun Adı")]
        [Required(ErrorMessage = "Adı Giriniz!")]
        [StringLength(20, ErrorMessage = "Ürün Adı 20 Karakter olmalıdır!")]
        public string UrunAdi { get; set; }



        [Display(Name = "Urun Açıklaması")]
        [Required(ErrorMessage = "Açıklama Giriniz!")]
        public string UrunAciklama { get; set; }



        [Display(Name = "Urun Fiyat")]
        [Required(ErrorMessage = "Fiyat Giriniz!")]
        public decimal UrunFiyat { get; set; }


        [Display(Name = "Aktif")]
        public bool UrunAktif { get; set; }

    }
}
