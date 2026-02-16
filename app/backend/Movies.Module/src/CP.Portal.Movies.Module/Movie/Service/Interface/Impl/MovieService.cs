using CP.Portal.Movies.Module.Movie.Response;


namespace CP.Portal.Movies.Module.Movie.Service.Interface.Impl
{
    internal class MovieService : IMovieService
    {
        List<MovieResponse> IMovieService.GetMovies()
        {
            return new List<MovieResponse>
            {
                new MovieResponse(Guid.NewGuid(), "The Shawshank Redemption", "Two imprisoned"),
                new MovieResponse(Guid.NewGuid(), "The Godfather", "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
                new MovieResponse(Guid.NewGuid(), "The Dark Knight", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept"),
            };
        }
    }
}
