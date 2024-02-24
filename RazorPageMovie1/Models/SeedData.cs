using Microsoft.EntityFrameworkCore;
using RazorPageMovie1.Data;
using System.ComponentModel.DataAnnotations;

namespace RazorPageMovie1.Models
{
    public static class SeedData
    {
        public static void Initilize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageMovie1Context(serviceProvider.GetRequiredService<DbContextOptions<RazorPageMovie1Context>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                //Para mirar cualquier pelicula
                if (context.Movie.Any())
                {
                    return; //Db muestra todo lo que contiene la clase
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry met Sally",
                        ReleaseDate = new DateTime(1989,2,12),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = new DateTime(1984,3,13),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating= "G"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = new DateTime(1986,2,23),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "G"
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = new DateTime(1959,4,15),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "NA"
                    }
                    );
                context.SaveChanges();
            }
            
        }
        
    }
}
