using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YasayanKutuphane.Data;
using YasayanKutuphane.Models;

namespace YasayanKutuphane.Pages.Admin.Kategori
{
    public class DetailsModel : PageModel
    {
        private readonly YasayanKutuphane.Data.ApplicationDbContext _context;

        public DetailsModel(YasayanKutuphane.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public YasayanKutuphane.Models.Kategori Kategori { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Kategori = await _context.Kategori.FirstOrDefaultAsync(m => m.ID == id);

            if (Kategori == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
