﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YasayanKutuphane.Models
{
    public class Ulke
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Ulke Adi")]
        public string Isim { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
    }
}
