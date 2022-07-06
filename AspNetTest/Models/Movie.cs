using System.ComponentModel.DataAnnotations;



namespace AspNetTest.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public List<ActorInMovie> ActorInMovies { get; set; }

    }
}
