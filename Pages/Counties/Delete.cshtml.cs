using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tema_VLADULESCU_GABRIEL.Data;
using Tema_VLADULESCU_GABRIEL.Models;

namespace Tema_VLADULESCU_GABRIEL.Pages.Counties
{
    public class DeleteModel : PageModel
    {
        private readonly Tema_VLADULESCU_GABRIEL.Data.Tema_VLADULESCU_GABRIELContext _context;

        public DeleteModel(Tema_VLADULESCU_GABRIEL.Data.Tema_VLADULESCU_GABRIELContext context)
        {
            _context = context;
        }

        [BindProperty]
      public County County { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.County == null)
            {
                return NotFound();
            }

            var county = await _context.County.FirstOrDefaultAsync(m => m.ID == id);

            if (county == null)
            {
                return NotFound();
            }
            else 
            {
                County = county;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.County == null)
            {
                return NotFound();
            }
            var county = await _context.County.FindAsync(id);

            if (county != null)
            {
                County = county;
                _context.County.Remove(County);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
