using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YasayanKutuphane.Models
{
    class Ulke
    {
        [Key]
        public int ID {get; set;}
        [Required]
        [Display(Name = "UlkeAdi")]
        public string Name {get; set;}
        [Required]
        public int DisplayOrder {get; set;}

    }
}
