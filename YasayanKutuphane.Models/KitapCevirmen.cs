using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace YasayanKutuphane.Models
{
    public class KitapCevirmen
    {
        [Key]
        public int ID { get; set; }

        public int CevirmenID { get; set; }
        [ForeignKey("CevirmenID")]
        public virtual Cevirmen Cevirmen { get; set; }
        public int DisplayOrder { get; set; }
        public int KitapID { get; set; }
        [ForeignKey("KitapID")]
        public virtual Kitap Kitap { get; set; }
    }
}
