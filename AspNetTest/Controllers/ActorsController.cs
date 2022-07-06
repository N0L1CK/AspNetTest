using Microsoft.AspNetCore.Mvc;
using AspNetTest.Data;

namespace AspNetTest.Controllers
{
    public class ActorsController : Controller
    {

        private readonly AppDbContext context;

        public ActorsController(AppDbContext context) 
        {
            this.context = context; 
        }

        public IActionResult Index(string searchActor)
        {
            var data = context.Actors.Where(x=>x.FullName.Equals(searchActor)).ToList();
            return View(data);
        }
    }
}
