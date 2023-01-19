using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tema_VLADULESCU_GABRIEL.Data;
using Tema_VLADULESCU_GABRIEL.Models;

namespace Tema_VLADULESCU_GABRIEL.Pages.Cinemas
{
    public class DeleteModel : PageModel
    {
        private readonly Tema_VLADULESCU_GABRIEL.Data.Tema_VLADULESCU_GABRIELContext _context;

        public DeleteModel(Tema_VLADULESCU_GABRIEL.Data.Tema_VLADULESCU_GABRIELContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Cinema Cinema { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cinema == null)
            {
                return NotFound();
            }

            var cinema = await _context.Cinema.FirstOrDefaultAsync(m => m.ID == id);

            if (cinema == null)
            {
                return NotFound();
            }
            else 
            {
                Cinema = cinema;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Cinema == null)
            {
                return NotFound();
            }
            var cinema = await _context.Cinema.FindAsync(id);

            if (cinema != null)
            {
                Cinema = cinema;
                _context.Cinema.Remove(Cinema);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
