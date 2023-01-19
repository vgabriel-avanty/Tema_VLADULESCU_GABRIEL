using System.ComponentModel.DataAnnotations;

namespace Tema_VLADULESCU_GABRIEL.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Titlul Filmului este necesar")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Data de Lansare a filmului este necesară")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Genul filmului este necesar")]
        public int MovieGenreID { get; set; }
        public MovieGenre MovieGenre { get; set; }

        [Required(ErrorMessage = "Rating-ul filmului este necesar")]
        [StringLength(5)]
        public string Rating { get; set; }

        public ICollection<Ticket>? Tickets { get; set; }
    }
}
