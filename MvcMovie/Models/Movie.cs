using System.ComponentModel.DataAnnotations;
using MovieList;
using FullMovieList;
namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
        public string? Developer { get; set; }
        public string? Storage { get; set; }
        public int? Rating { get; set; }
        public List<Review> Reviews { get; set; }
    }
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string ReviewText { get; set; }
    }
}

