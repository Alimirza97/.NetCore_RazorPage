using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YasayanKutuphane.Models
{
    //ekitap veya normal
    class KitapTuru
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "TurAdi")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}
