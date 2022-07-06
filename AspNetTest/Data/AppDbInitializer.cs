using System.Collections;
using AspNetTest.Models;

namespace AspNetTest.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context?.Database.EnsureCreated();
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Tim Robbins",
                            

                        },
                        new Actor()
                        {
                            FullName = "Morgan Freeman",
                            
                        },
                        new Actor()
                        {
                            FullName = "Christian Bale",
                            
                        },
                        new Actor()
                        {
                            FullName = "Heath Ledger",

                        },
                        new Actor()
                        {
                            FullName = "Al Pacino",

                        },
                        new Actor()
                        {
                            FullName = "Marlon Brando",

                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "The Godfather",
                            Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UY576_.jpg",
                            Genre = "Drama",
                            
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg",
                            Genre = "Drama",
                            
                        },
                        new Movie()
                        {
                            Name = "The Dark Knight",
                            Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UY720_.jpg",
                            Genre = "Action",
                            
                        },
                        new Movie()
                        {
                            Name = "The Godfather Part II",
                            Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMWMwMGQzZTItY2JlNC00OWZiLWIyMDctNDk2ZDQ2YjRjMWQ0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UY720_.jpg",
                            Genre = "Drama",
                            
                        },
                        new Movie()
                        {
                            Name = "12 Angry Men",
                            Description = "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMWU4N2FjNzYtNTVkNC00NzQ0LTg0MjAtYTJlMjFhNGUxZDFmXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_.jpg",
                            Genre = "Drama"
                        },
                        new Movie()
                        {
                            Name = "Schindler's List",
                            Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_FMjpg_UY720_.jpg",
                            Genre = "History"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.ActorInMovies.Any())
                {
                    context.ActorInMovies.AddRange(new List<ActorInMovie>()
                    {
                        new ActorInMovie()
                        {
                            ActorId = 1,
                            MovieId = 2,
                           

                        },
                        new ActorInMovie()
                        {
                            ActorId = 2,
                            MovieId = 2,
                            
                        },

                         new ActorInMovie()
                        {
                            ActorId = 3,
                            MovieId = 3,
                            
                        },
                         new ActorInMovie()
                        {
                            ActorId = 4,
                            MovieId = 3,
                           
                        },

                        new ActorInMovie()
                        {
                            ActorId = 5,
                            MovieId = 1,
                            
                        },
                        new ActorInMovie()
                        {
                            ActorId = 5,
                            MovieId = 4,
                            
                        },
                        new ActorInMovie()
                        {
                            ActorId = 6,
                            MovieId = 1,
                            
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
