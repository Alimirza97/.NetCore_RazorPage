using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YasayanKutuphane.Data;
using YasayanKutuphane.Models;

namespace YasayanKutuphane.Pages.Admin.Dil
{
    public class DeleteModel : PageModel
    {
        private readonly YasayanKutuphane.Data.ApplicationDbContext _context;

        public DeleteModel(YasayanKutuphane.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public YasayanKutuphane.Models.Dil Dil { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dil = await _context.Dil.FirstOrDefaultAsync(m => m.ID == id);

            if (Dil == null)
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

            Dil = await _context.Dil.FindAsync(id);

            if (Dil != null)
            {
                _context.Dil.Remove(Dil);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
