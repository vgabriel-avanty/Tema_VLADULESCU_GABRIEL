using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tema_VLADULESCU_GABRIEL.Data;
using Tema_VLADULESCU_GABRIEL.Models;

namespace Tema_VLADULESCU_GABRIEL.Pages.CinemaLocations
{
    public class DeleteModel : PageModel
    {
        private readonly Tema_VLADULESCU_GABRIEL.Data.Tema_VLADULESCU_GABRIELContext _context;

        public DeleteModel(Tema_VLADULESCU_GABRIEL.Data.Tema_VLADULESCU_GABRIELContext context)
        {
            _context = context;
        }

        [BindProperty]
      public CinemaLocation CinemaLocation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CinemaLocation == null)
            {
                return NotFound();
            }

            var cinemalocation = await _context.CinemaLocation.FirstOrDefaultAsync(m => m.ID == id);

            if (cinemalocation == null)
            {
                return NotFound();
            }
            else 
            {
                CinemaLocation = cinemalocation;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CinemaLocation == null)
            {
                return NotFound();
            }
            var cinemalocation = await _context.CinemaLocation.FindAsync(id);

            if (cinemalocation != null)
            {
                CinemaLocation = cinemalocation;
                _context.CinemaLocation.Remove(CinemaLocation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
