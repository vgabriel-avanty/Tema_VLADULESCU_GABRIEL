using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tema_VLADULESCU_GABRIEL.Models;

namespace Tema_VLADULESCU_GABRIEL.Data
{
    public class Tema_VLADULESCU_GABRIELContext : DbContext
    {
        public Tema_VLADULESCU_GABRIELContext (DbContextOptions<Tema_VLADULESCU_GABRIELContext> options)
            : base(options)
        {
        }

        public DbSet<Tema_VLADULESCU_GABRIEL.Models.County> County { get; set; } = default!;

        public DbSet<Tema_VLADULESCU_GABRIEL.Models.Cinema> Cinema { get; set; }

        public DbSet<Tema_VLADULESCU_GABRIEL.Models.MovieGenre> MovieGenre { get; set; }

        public DbSet<Tema_VLADULESCU_GABRIEL.Models.Movie> Movie { get; set; }

        public DbSet<Tema_VLADULESCU_GABRIEL.Models.Ticket> Ticket { get; set; }

        public DbSet<Tema_VLADULESCU_GABRIEL.Models.CinemaLocation> CinemaLocation { get; set; }

        internal Task<ProducesResponseTypeAttribute> SaveProduct(Movie product)
        {
            throw new NotImplementedException();
        }
    }
}
