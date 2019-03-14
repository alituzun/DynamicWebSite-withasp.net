using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Site.Data.Model
{
    [Table("Kullanici")]
    public class Kullanici
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(150, ErrorMessage = "Lütfen 150 karakterden fazla değer girmeyiniz.")]
        [Display(Name = "Ad Soyad")]
        public string AdSoyad { get; set; }

        [Display(Name = "E-mail")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Geçerli bir e-mail adresi giriniz.")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [MaxLength(16, ErrorMessage = "Lütfen 16 karakterden fazla değer girmeyiniz.")]
        [Required]
        public string Sifre { get; set; }

        [Display(Name = "Kayıt tarifi")]
        public DateTime KayitTarihi { get; set; }

        [Display(Name = "Aktif")]
        public bool Aktif { get; set; }

        public virtual Rol Rol { get; set; }


    }
}