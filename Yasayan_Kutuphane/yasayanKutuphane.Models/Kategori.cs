using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace yasayanKutuphane.Models
{
    class Kategori
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "KategoriAdi")]
        public string Isim { get; set; }
        [Required]
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }
    }
}
