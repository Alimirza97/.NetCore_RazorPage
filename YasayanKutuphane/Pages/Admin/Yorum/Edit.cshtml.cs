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

namespace YasayanKutuphane.Pages.Admin.Yorum
{
    public class EditModel : PageModel
    {
        private readonly YasayanKutuphane.Data.ApplicationDbContext _context;

        public EditModel(YasayanKutuphane.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public YasayanKutuphane.Models.Yorum Yorum { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Yorum = await _context.Yorum
                .Include(y => y.Kitap).FirstOrDefaultAsync(m => m.ID == id);

            if (Yorum == null)
            {
                return NotFound();
            }
           ViewData["KitapID"] = new SelectList(_context.Kitap, "ID", "ID");
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

            _context.Attach(Yorum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YorumExists(Yorum.ID))
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

        private bool YorumExists(int id)
        {
            return _context.Yorum.Any(e => e.ID == id);
        }
    }
}
