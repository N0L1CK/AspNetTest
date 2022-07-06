
namespace AspNetTest.Models

{
    public class ActorInMovie
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        
    }
}
