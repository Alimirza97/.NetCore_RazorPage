using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YasayanKutuphane.Models
{
    public class Yayinevi
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "YayineviAdi")]
        public string Isim { get; set; }
        [Required]
        [Display(Name = "DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}
