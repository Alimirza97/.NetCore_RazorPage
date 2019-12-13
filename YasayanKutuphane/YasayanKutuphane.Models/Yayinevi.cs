using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YasayanKutuphane.Models
{
    class Yayinevi
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "YayineviAdi")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}
