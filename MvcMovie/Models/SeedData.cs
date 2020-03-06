using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Religious Comedy",
                        Price = 7.99M,
                        Rating = "PG",
                        Image = "/img/theRM.jpg"
                    },

                    new Movie
                    {
                        Title = "Other Side of Heaven ",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Drama",
                        Price = 8.99M,
                        Rating = "PG",
                        Image = "/img/OtherSide.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG",
                        Image = "/img/meetTheMormons.jpg"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Adventure",
                        Price = 3.99M,
                        Rating = "PG",
                        Image = "/img/seventeenMiracles.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}