using CP.Portal.Movies.Module.Movie.Response;


namespace CP.Portal.Movies.Module.Movie.Service.Interface
{
    public interface IMovieService
    {
        List<MovieResponse> GetMovies();
      
    }
}
