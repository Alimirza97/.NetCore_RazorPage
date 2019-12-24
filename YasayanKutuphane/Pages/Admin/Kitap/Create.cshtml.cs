using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using YasayanKutuphane.Data;
using YasayanKutuphane.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace YasayanKutuphane.Pages.Admin.Kitap
{
    public class CreateModel : PageModel
    {
        private readonly YasayanKutuphane.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public CreateModel(YasayanKutuphane.Data.ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
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
        public YasayanKutuphane.Models.Kitap Kitap { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            if (!ModelState.IsValid)
            {
                return Page();
            }
            string fileName = Guid.NewGuid().ToString();
            var uploads = Path.Combine(webRootPath, @"img\Kitap");
            var extension = Path.GetExtension(files[0].FileName);

            using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
            {
                files[0].CopyTo(fileStream);
            }
            Kitap.KapakFotografi = @"\img\Kitap\" + fileName + extension;

            _context.Kitap.Add(Kitap);

            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
