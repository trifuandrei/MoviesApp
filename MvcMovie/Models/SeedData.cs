using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using MvcMovie.Models;
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
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    },
                    new Movie
                    {
                        Title = "Rocket League",
                        ReleaseDate = DateTime.Parse("2015-7-7"),
                        Genre = "Cars",
                        Price = 9.99M,
                        Developer = "Psyonix",
                        Storage = "20GB",
                        Rating=86,
                    },
                    new Movie
                    {
                        Title = "The Witcher 3",
                        ReleaseDate = DateTime.Parse("2015-5-15"),
                        Genre = "Open-World",
                        Price = 29.99M,
                        Developer = "CD Projekt Red",
                        Storage = "50GB",
                        Rating = 93,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
