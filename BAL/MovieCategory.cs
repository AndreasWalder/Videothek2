using System;
using System.Collections.Generic;

#nullable disable

namespace Videothek2.BAL
{
    public partial class MovieCategory
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
