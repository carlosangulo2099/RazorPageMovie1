using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageMovie1.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [StringLength(60,MinimumLength = 3)]
        public string? Title { get; set; }

        [DataType(DataType.Date), Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"),Required,StringLength(30)]
        public string? Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)"),Range(1,100),DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s]*$"),StringLength(5),Required]
        public string? Rating { get; set; }
    }
}
