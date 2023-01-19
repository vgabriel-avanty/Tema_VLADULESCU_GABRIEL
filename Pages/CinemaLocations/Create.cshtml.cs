using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tema_VLADULESCU_GABRIEL.Data;
using Tema_VLADULESCU_GABRIEL.Models;

namespace Tema_VLADULESCU_GABRIEL.Pages.CinemaLocations
{
    public class CreateModel : PageModel
    {
        private readonly Tema_VLADULESCU_GABRIEL.Data.Tema_VLADULESCU_GABRIELContext _context;

        public CreateModel(Tema_VLADULESCU_GABRIEL.Data.Tema_VLADULESCU_GABRIELContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CinemaID"] = new SelectList(_context.Cinema, "ID", "Name");
        ViewData["CountyID"] = new SelectList(_context.County, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public CinemaLocation CinemaLocation { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CinemaLocation.Add(CinemaLocation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
