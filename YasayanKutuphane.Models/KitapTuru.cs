﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YasayanKutuphane.Models
{
    //ekitap kitap
    public class KitapTuru
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "TurAdi")]
        public string Isim { get; set; }
        [Required]
        [Display(Name = "DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}
