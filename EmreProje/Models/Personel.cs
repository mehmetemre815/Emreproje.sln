using System.ComponentModel.DataAnnotations;

namespace EmreProje.Models
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }

        [Display(Name = "MAİLİNİZ")]
        [Required(ErrorMessage = "Mailinizi Giriniz!")]
        public string PersonelMail { get; set; }

        [Display(Name = "SİFRENİZ")]
        [Required(ErrorMessage = "Sifrenizi Giriniz!")]
        public string PersonelSifre { get; set; }


        [Display(Name = "ADINIZ")]
        [Required(ErrorMessage = "Adınızı Giriniz!")]
        public string PersonelAdi { get; set; }

        [Display(Name = "SOYADINIZ")]
        [Required(ErrorMessage = "Soydınızı Giriniz!")]
        public string PersonelSoyadi { get; set; }

        [Display(Name = "TELEFON NUMARANIZ")]
        [Required(ErrorMessage = "TELEFONUNUZU GİRİNİZ!")]
        public int PersonelTelefon { get; set; }


        [Display(Name = "Aktif")]
        public bool PersonelAktif { get; set; }
    }
}
