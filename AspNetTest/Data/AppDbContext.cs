using Microsoft.EntityFrameworkCore;
using AspNetTest.Models;


namespace AspNetTest.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<ActorInMovie>().HasKey(am => new
            {
                
                am.ActorId,
                am.MovieId
                
            });

            modelBuilder.Entity<ActorInMovie>().HasOne(m => m.Movie).WithMany(am => am.ActorInMovies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<ActorInMovie>().HasOne(m => m.Actor).WithMany(am => am.ActorInMovies).HasForeignKey(m => m.ActorId);
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorInMovie> ActorInMovies { get; set; }
    }
}
