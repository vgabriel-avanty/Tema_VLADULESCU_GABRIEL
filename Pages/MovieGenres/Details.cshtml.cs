using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tema_VLADULESCU_GABRIEL.Data;
using Tema_VLADULESCU_GABRIEL.Models;

namespace Tema_VLADULESCU_GABRIEL.Pages.MovieGenres
{
    public class DetailsModel : PageModel
    {
        private readonly Tema_VLADULESCU_GABRIEL.Data.Tema_VLADULESCU_GABRIELContext _context;

        public DetailsModel(Tema_VLADULESCU_GABRIEL.Data.Tema_VLADULESCU_GABRIELContext context)
        {
            _context = context;
        }

      public MovieGenre MovieGenre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MovieGenre == null)
            {
                return NotFound();
            }

            var moviegenre = await _context.MovieGenre.FirstOrDefaultAsync(m => m.ID == id);
            if (moviegenre == null)
            {
                return NotFound();
            }
            else 
            {
                MovieGenre = moviegenre;
            }
            return Page();
        }
    }
}
