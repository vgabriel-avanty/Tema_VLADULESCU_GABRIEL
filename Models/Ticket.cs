using System.ComponentModel.DataAnnotations;

namespace Tema_VLADULESCU_GABRIEL.Models
{
    public class Ticket
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Prenumele este necesar")]
        [Display(Name = "Prenume")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Numele este necesar")]
        [Display(Name = "Nume")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Cinema-ul este necesar")]
        [Display(Name = "Locație Cinema")]
        public int CinemaLocationID { get; set; }
        public CinemaLocation? CinemaLocation { get; set; }

        [Required(ErrorMessage = "Filmul este necesar")]
        [Display(Name = "Film")]
        public int MovieID { get; set; }
        public Movie? Movie { get; set; }

        [Required(ErrorMessage = "Data este necesară")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TicketDate { get; set; }
    }
}
