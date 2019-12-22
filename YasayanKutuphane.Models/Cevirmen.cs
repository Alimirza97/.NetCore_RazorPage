using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace YasayanKutuphane.Models
{
    public class Cevirmen
    {
        [Key]
        public int ID { get; set; }
        public int UlkeID { get; set; }
        [ForeignKey("UlkeID")]
        public virtual Ulke Ulke { get; set; }

        public string Isim { get; set; }
        public string Soyisim { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DogumTarihi { get; set; }
        public CinsiyetTipi Cinsiyet { get; set; }
        public virtual ICollection<KitapCevirmen> KitapCevirmen { get; set; }
        public string TamIsim
        {
            get
            {
                return Isim + " " + Soyisim;
            }


        }
    }
}
