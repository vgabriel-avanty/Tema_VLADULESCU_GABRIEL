using System.ComponentModel.DataAnnotations;

namespace Tema_VLADULESCU_GABRIEL.Models
{
    public class CinemaLocation
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Noua Locație este necesar")]
        [Display(Name = "Locație")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Cinema-ul este necesar")]
        [Display(Name = "Cinema")]
        public int CinemaID { get; set; }
        public Cinema? Cinema { get; set; }

        [Required(ErrorMessage = "Județul Cinema-ului este necesar")]
        [Display(Name = "Județ")]
        public int CountyID { get; set; }
        public County? County { get; set; }

        public ICollection<Ticket>? Tickets { get; set; }
    }
}
