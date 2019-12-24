using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YasayanKutuphane.Pages.Customer.Home
{
    public class IndexModel : PageModel
    {
        private readonly YasayanKutuphane.Data.ApplicationDbContext _db;
        public IndexModel(YasayanKutuphane.Data.ApplicationDbContext db)
        {
            _db = db;
        }

        public List<YasayanKutuphane.Models.Kitap> Satista { get; set; }
        public List<YasayanKutuphane.Models.Kitap> CokYakinda { get; set; }
        public void OnGet()
        {
            Satista = _db.Kitap.ToList();

        }
    }
}