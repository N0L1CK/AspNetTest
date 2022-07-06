using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetTest.Data;
using AspNetTest.Models;

namespace AspNetTest.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext context;

        public MoviesController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index(string movieGenre, string searchString, string searchActor)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in context.Movies
                                            orderby m.Genre
                                            select m.Genre;

            var movies = from m in context.Movies
                         select m;




            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Name.Contains(searchString));

            }

            if (!string.IsNullOrEmpty(searchActor))
            {
                
                var actors = context.Actors.Where(m=>m.FullName.StartsWith(searchActor));
                var movId = from i in context.ActorInMovies join a in actors on i.ActorId equals a.Id select i;
                
                movies = from m in movies join a in movId on m.Id equals a.MovieId select m;
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            var movieVM = new MovieViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Movies = await movies.ToListAsync()
            };
            
            return View(movieVM);

        }
 
    }
}
