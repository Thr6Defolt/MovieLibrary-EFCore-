using Microsoft.EntityFrameworkCore.Sqlite;
using SQLitePCL;

namespace MovieLibrary_EFCore_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MovieDbContext())
            {
                context.Movies.Add(new Movie { Name = "Pig Pepa", Article = "1234" });
                context.Movies.Add(new Movie { Name = "War Craft", Article = "9090" });
                context.Movies.Add(new Movie { Name = "50 gray shades", Article = "5678" });
                context.Movies.Add(new Movie { Name = "Jon Wik", Article = "228" });

                context.SaveChanges();
            }

            using (var context = new MovieDbContext())
            {
                var movieLibrary = new MovieLibrary(context);
                movieLibrary.GetAllMovie();
                movieLibrary.GetMovie("1234");
            }
        }
    }
}