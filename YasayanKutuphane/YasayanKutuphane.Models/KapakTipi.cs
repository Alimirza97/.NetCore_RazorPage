using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YasayanKutuphane.Models
{
    //ince kapak ya da ciltli
    class KapakTipi
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "DilAdi")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}
