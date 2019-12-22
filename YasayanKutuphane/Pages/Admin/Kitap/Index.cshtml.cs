using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YasayanKutuphane.Data;
using YasayanKutuphane.Models;

namespace YasayanKutuphane
{
    public class IndexModel : PageModel
    {
        private readonly YasayanKutuphane.Data.ApplicationDbContext _context;

        public IndexModel(YasayanKutuphane.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Kitap> Kitap { get;set; }

        public async Task OnGetAsync()
        {
            Kitap = await _context.Kitap
                .Include(k => k.Dil)
                .Include(k => k.KapakTipi)
                .Include(k => k.Kategori)
                .Include(k => k.KitapTuru)
                .Include(k => k.Yayinevi).ToListAsync();
        }
    }
}
