﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace yasayanKutuphane.Models
{
    class Dil
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Dil Adi")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }

    }
}