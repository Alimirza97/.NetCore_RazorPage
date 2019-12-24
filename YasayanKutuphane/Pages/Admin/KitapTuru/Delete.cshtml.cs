using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YasayanKutuphane.Data;
using YasayanKutuphane.Models;

namespace YasayanKutuphane.Pages.Admin.KitapTuru
{
    public class DeleteModel : PageModel
    {
        private readonly YasayanKutuphane.Data.ApplicationDbContext _context;

        public DeleteModel(YasayanKutuphane.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public YasayanKutuphane.Models.KitapTuru KitapTuru { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            KitapTuru = await _context.KitapTuru.FirstOrDefaultAsync(m => m.ID == id);

            if (KitapTuru == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            KitapTuru = await _context.KitapTuru.FindAsync(id);

            if (KitapTuru != null)
            {
                _context.KitapTuru.Remove(KitapTuru);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
