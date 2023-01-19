using System.ComponentModel.DataAnnotations;

namespace Tema_VLADULESCU_GABRIEL.Models
{
    public class Cinema
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Numele Cinema-ului este necesar")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Locația Cinema-ului este necesară")]
        public int CinemaLocationID { get; set; }
        public County County { get; set; }

        public ICollection<Ticket>? Tickets { get; set; }
    }
}
