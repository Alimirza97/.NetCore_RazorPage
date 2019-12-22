using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YasayanKutuphane.Data;
using YasayanKutuphane.Models;

namespace YasayanKutuphane
{
    public class EditModel : PageModel
    {
        private readonly YasayanKutuphane.Data.ApplicationDbContext _context;

        public EditModel(YasayanKutuphane.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["DilID"] = new SelectList(_context.Dil, "ID", "Isim");
           ViewData["KapakTipiID"] = new SelectList(_context.KapakTipi, "ID", "Isim");
           ViewData["KategoriID"] = new SelectList(_context.Kategori, "ID", "Isim");
           ViewData["KitapTuruID"] = new SelectList(_context.KitapTuru, "ID", "Isim");
           ViewData["YayineviID"] = new SelectList(_context.Yayinevi, "ID", "Isim");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Kitap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KitapExists(Kitap.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool KitapExists(int id)
        {
            return _context.Kitap.Any(e => e.ID == id);
        }
    }
}
