using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tema_VLADULESCU_GABRIEL.Data;
using Tema_VLADULESCU_GABRIEL.Models;

namespace Tema_VLADULESCU_GABRIEL.Pages.Tickets
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
            var List = _context.CinemaLocation
            .Include(b => b.Cinema)
            .Include(b => b.County)
            .Select(x => new
            {
                x.ID,
                SelectionName = x.Cinema.Name + " - Județ: " + x.County.Name + " Locație: " + x.Location
            });

            ViewData["CinemaLocationID"] = new SelectList(List, "ID", "SelectionName");
            ViewData["MovieID"] = new SelectList(_context.Movie, "ID", "Title");
            return Page();
        }

        [BindProperty]
        public Ticket Ticket { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ticket.Add(Ticket);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
