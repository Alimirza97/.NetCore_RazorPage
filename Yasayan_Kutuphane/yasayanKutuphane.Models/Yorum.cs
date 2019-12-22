using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace yasayanKutuphane.Models
{
    class Yorum
    {
        [Key]
        public int ID { get; set; }
        public int KitapID { get; set; }
        [ForeignKey("KitapID")]
        public virtual Kitap Kitap { get; set; }
        public DateTime YorumTarihi { get; set; }
        public string Icerik { get; set; }

        
    }
}

