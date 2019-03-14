
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Data.Model
{
    [Table("Rol")]
    public class Rol
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Rol Adı")]
        [MinLength(3, ErrorMessage = "Lütfen 3 karakterden fazla değer giriniz."), MaxLength(150, ErrorMessage = "Karakter sayısı 150'yi geçmemesi gerekir.")]
        public string RolAdi { get; set; }
    }
}