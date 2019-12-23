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
    public class IndexModel : PageModel
    {
        private readonly YasayanKutuphane.Data.ApplicationDbContext _context;

        public IndexModel(YasayanKutuphane.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<YasayanKutuphane.Models.Dil> Dil { get;set; }

        public async Task OnGetAsync()
        {
            Dil = await _context.Dil.ToListAsync();
        }
    }
}
