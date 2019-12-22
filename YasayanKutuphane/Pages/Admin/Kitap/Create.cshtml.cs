using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using YasayanKutuphane.Data;
using YasayanKutuphane.Models;

namespace YasayanKutuphane
{
    public class CreateModel : PageModel
    {
        private readonly YasayanKutuphane.Data.ApplicationDbContext _context;

        public CreateModel(YasayanKutuphane.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DilID"] = new SelectList(_context.Dil, "ID", "Isim");
        ViewData["KapakTipiID"] = new SelectList(_context.KapakTipi, "ID", "Isim");
        ViewData["KategoriID"] = new SelectList(_context.Kategori, "ID", "Isim");
        ViewData["KitapTuruID"] = new SelectList(_context.KitapTuru, "ID", "Isim");
        ViewData["YayineviID"] = new SelectList(_context.Yayinevi, "ID", "Isim");
            return Page();
        }

        [BindProperty]
        public Kitap Kitap { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Kitap.Add(Kitap);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
