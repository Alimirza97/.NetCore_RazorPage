using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace yasayanKutuphane.Models
{
    class Kitap
    {
        [Key]
        public int ID { get; set; }

        public int KategoriID { get; set; }
        [ForeignKey("KategoriID")]
        public virtual Kategori Kategori { get; set; }
        public int DilID { get; set; }
        [ForeignKey("DilID")]
        public virtual Dil Dil { get; set; }
        public int YayineviID { get; set; }
        [ForeignKey("YayineviID")]
        public virtual Yayinevi Yayinevi { get; set; }

        public string Isim { get; set; }
        public string Tanitim { get; set; }
        public string KapakFotografi { get; set; }
        public DateTime BasimTarihi { get; set; }
        public int SayfaSayisi { get; set; }

        public int StokMiktari { get; set; }
        public double Puan { get; set; }
        public virtual ICollection<KitapYazar> KitapYazar { get; set; }
        public virtual ICollection<KitapCevirmen> KitapCevirmen { get; set; }

        //public bool SilinmeliMi()
        //{
        //    if (StokMiktari == 0) return true;
        //    else return false;
        //}
    }
}
