using System.ComponentModel.DataAnnotations;

//When you run the code, add /Movies at the end of the localhost URL 

namespace MvcMovie.Models
{
    public class Movie
    {

        public int MovieID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string? MovieTitle { get; set; }

        [DataType(DataType.Date)]
        public DateTime? MovieReleaseDate { get; set; }

        public string? MovieGenre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal MoviePrice  { get; set; }



    }

}
