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
    public class IndexModel : PageModel
    {
        private readonly Tema_VLADULESCU_GABRIEL.Data.Tema_VLADULESCU_GABRIELContext _context;

        public IndexModel(Tema_VLADULESCU_GABRIEL.Data.Tema_VLADULESCU_GABRIELContext context)
        {
            _context = context;
        }

        public IList<CinemaLocation> CinemaLocation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CinemaLocation != null)
            {
                CinemaLocation = await _context.CinemaLocation
                .Include(c => c.Cinema)
                .Include(c => c.County).ToListAsync();
            }
        }
    }
}
