using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary_EFCore_
{
    internal class MovieLibrary
    {
        private readonly MovieDbContext _context;

        public MovieLibrary(MovieDbContext context)
        {
            _context = context;
        }

        public void GetAllMovie()
        {
            var movies = _context.Movies.ToList();
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Article}, {movie.Name}");
            };

        }
        
        public void GetMovie(string article)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Article == article);
            if (movie != null)
            {
                Console.WriteLine($"{movie.Article}, {movie.Name}");
            }
            else
            {
                Console.WriteLine("Не знайдено");
            }
        }
    }
}
