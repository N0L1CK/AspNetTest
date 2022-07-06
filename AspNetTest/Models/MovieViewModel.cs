using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AspNetTest.Models
{
    public class MovieViewModel
    {
        public List<Movie> Movies { get; set; }
        public string SearchString { get; set; }
        public string SearchActor { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
    }
}
