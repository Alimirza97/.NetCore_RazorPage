using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YasayanKutuphane.Models;

namespace YasayanKutuphane.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet <Kitap> Kitap { get; set; }
        public DbSet<Cevirmen> Cevirmen { get; set; }
        public DbSet<Dil> Dil { get; set; }
        public DbSet<KapakTipi> KapakTipi { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<KitapCevirmen> KitapCevirmen { get; set; }
        public DbSet<KitapTuru> KitapTuru { get; set; }
        public DbSet<KitapYazar> KitapYazar { get; set; }
        public DbSet<Ulke> Ulke { get; set; }
        public DbSet<Yayinevi> Yayinevi { get; set; }
        public DbSet<Yazar> Yazar { get; set; }
        public DbSet<Yorum> Yorum { get; set; }

    }
}
