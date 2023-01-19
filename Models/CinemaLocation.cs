using System.ComponentModel.DataAnnotations;

namespace Tema_VLADULESCU_GABRIEL.Models
{
    public class CinemaLocation
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Locația este necesară")]
        public string? Name { get; set; }

        public ICollection<Cinema>? Cinemas { get; set; }
    }
}
