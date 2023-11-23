using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary_EFCore_
{
    internal class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Article { get; set; }
    }
}
