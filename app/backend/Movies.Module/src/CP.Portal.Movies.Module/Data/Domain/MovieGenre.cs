using System;
using System.Collections.Generic;
using System.Text;

namespace CP.Portal.Movies.Module.Data.Domain
{
    internal class MovieGenre
    {
        public Guid MovieId { get; private set; }
        public Guid GenreId { get; private set; }

        public Movie? Movie { get; private set; }
        public Genre? Genre { get; private set; }
        internal MovieGenre(Guid movieId, Guid genreId)
        {
            MovieId = movieId;
            GenreId = genreId;
        }
    }
}
