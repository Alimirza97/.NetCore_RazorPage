using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace YasayanKutuphane.Models
{
    class KitapYazar
    {
        [Key]
        public int ID { get; set; }

        public int YazarID { get; set; }
        [ForeignKey("YazarID")]
        public virtual Yazar Yazar { get; set; }
        public int DisplayOrder { get; set; }
        public int KitapID { get; set; }
        [ForeignKey("KitapID")]
        public virtual Kitap Kitap { get; set; }

        


    }
}
