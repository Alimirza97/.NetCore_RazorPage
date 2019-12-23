using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YasayanKutuphane.Data;
using YasayanKutuphane.Models;

namespace YasayanKutuphane.Pages.Admin.Yayinevi
{
    public class DetailsModel : PageModel
    {
        private readonly YasayanKutuphane.Data.ApplicationDbContext _context;

        public DetailsModel(YasayanKutuphane.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public YasayanKutuphane.Models.Yayinevi Yayinevi { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Yayinevi = await _context.Yayinevi.FirstOrDefaultAsync(m => m.ID == id);

            if (Yayinevi == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
