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
    public class DetailsModel : PageModel
    {
        private readonly YasayanKutuphane.Data.ApplicationDbContext _context;

        public DetailsModel(YasayanKutuphane.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Kitap Kitap { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Kitap = await _context.Kitap
                .Include(k => k.Dil)
                .Include(k => k.KapakTipi)
                .Include(k => k.Kategori)
                .Include(k => k.KitapTuru)
                .Include(k => k.Yayinevi).FirstOrDefaultAsync(m => m.ID == id);

            if (Kitap == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
