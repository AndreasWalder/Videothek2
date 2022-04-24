using System;
using System.Collections.Generic;

#nullable disable

namespace Videothek2.BAL
{
    public partial class Movie
    {
        public Movie()
        {
            MovieCategories = new HashSet<MovieCategory>();
        }

        public int Id { get; set; }
        public int MainActressId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual MainActress MainActress { get; set; }
        public virtual ICollection<MovieCategory> MovieCategories { get; set; }
    }
}
