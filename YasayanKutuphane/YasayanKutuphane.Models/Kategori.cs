using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YasayanKutuphane.Models
{
    class Kategori
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display (Name="KategoriAdi")]
        public string Name { get; set;}

        [Required]
        [Display(Name = "DisplayOrder")]
        public int DisplayOrder { get; set; }


    }
}
