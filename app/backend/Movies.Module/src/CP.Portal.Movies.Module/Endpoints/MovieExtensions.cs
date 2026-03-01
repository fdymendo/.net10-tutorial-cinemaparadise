using CP.Portal.Movies.Module.Data.Domain;
using CP.Portal.Movies.Module.Endpoints.CreateMovie;

namespace CP.Portal.Movies.Module.Endpoints;

internal static class MovieExtensions
{
    extension(Movie movie)
    {
        public MovieResponse ToMovieResponse()
        {
            return new MovieResponse(
                movie.MovieId, 
                movie.Title, 
                movie.Synopsis ?? string.Empty,
                movie.RentalPrice
            );
        }
    }

    extension(CreateMovieRequest req)
    {
        public Movie ToMovie()
        {
            return new Movie(
                req.Title,
                req.ReleaseYear,
                req.DurationMinutes,
                req.Language ?? "en",
                req.Price,
                req.OriginalTitle,
                req.Description
            );
        }
    }
}
