using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using YasayanKutuphane.Data;
using YasayanKutuphane.Models;

namespace YasayanKutuphane.Pages.Admin.Cevirmen
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
        ViewData["UlkeID"] = new SelectList(_context.Ulke, "ID", "Isim");
            return Page();
        }

        [BindProperty]
        public YasayanKutuphane.Models.Cevirmen Cevirmen { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cevirmen.Add(Cevirmen);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
