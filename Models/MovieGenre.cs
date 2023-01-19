using System.ComponentModel.DataAnnotations;

namespace Tema_VLADULESCU_GABRIEL.Models
{
    public class MovieGenre
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Numele Genul este necesar")]
        [Display(Name = "Nume Gen Film")]
        public string? Name { get; set; }
        public ICollection<Movie>? Movies { get; set; }
    }
}
