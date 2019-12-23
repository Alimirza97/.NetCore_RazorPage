using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using YasayanKutuphane.Data;
using YasayanKutuphane.Models;

namespace YasayanKutuphane.Pages.Admin.Yorum
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
        ViewData["KitapID"] = new SelectList(_context.Kitap, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public YasayanKutuphane.Models.Yorum Yorum { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Yorum.Add(Yorum);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
