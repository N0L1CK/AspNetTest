using System.ComponentModel.DataAnnotations;

namespace AspNetTest.Models
{
    public class Actor
    {

        [Key]
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        public List<ActorInMovie> ActorInMovies { get; set; }

    }
}
