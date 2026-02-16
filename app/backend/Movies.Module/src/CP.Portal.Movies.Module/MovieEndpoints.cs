using CP.Portal.Movies.Module.Movie.Service.Interface;
using Microsoft.AspNetCore.Builder;

namespace CP.Portal.Movies.Module
{

    public static class MovieEndpoints
    {
        public static void MapMoviesEndpoints(this WebApplication app)
        {
            app.MapGet("/movies", (IMovieService movieService) =>
            {
                var movies = movieService.GetMovies();
                return movies;
            });
        }
    }
}
