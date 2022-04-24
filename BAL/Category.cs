using System;
using System.Collections.Generic;

#nullable disable

namespace Videothek2.BAL
{
    public partial class Category
    {
        public Category()
        {
            MovieCategories = new HashSet<MovieCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MovieCategory> MovieCategories { get; set; }
    }
}
