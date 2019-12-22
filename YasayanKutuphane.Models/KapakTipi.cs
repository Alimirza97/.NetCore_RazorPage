using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YasayanKutuphane.Models
{
    //ince kapak, ciltli
    public class KapakTipi
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "TipAdi")]
        public string Isim { get; set; }
        [Required]
        [Display(Name = "DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}
