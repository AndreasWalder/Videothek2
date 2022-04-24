using System;
using System.Collections.Generic;

#nullable disable

namespace Videothek2.BAL
{
    public partial class MainActress
    {
        public MainActress()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
