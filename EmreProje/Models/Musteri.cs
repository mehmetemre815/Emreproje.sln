using System.ComponentModel.DataAnnotations;

namespace EmreProje.Models
{
    public class Musteri
    {
        [Key]
        public int MusteriId { get; set; }

        [Display(Name = "MAİLİNİZ")]
        [Required(ErrorMessage = "Mailinizi Giriniz!")]
        public string MusteriMail { get; set; }


        [Display(Name = "ADINIZ")]
        [Required(ErrorMessage = "Adınızı Giriniz!")]
        public string MusteriAdi { get; set; }

        [Display(Name = "SOYADINIZ")]
        [Required(ErrorMessage = "Soydınızı Giriniz!")]
        public string MusteriSoyadi { get; set; }

        [Display(Name = "TELEFON NUMARANIZ")]
        [Required(ErrorMessage = "TELEFONUNUZU GİRİNİZ!")]
        public int MusteriTelefon { get; set; }


        [Display(Name = "Aktif")]
        public bool MusteriAktif { get; set; }
    }
}
