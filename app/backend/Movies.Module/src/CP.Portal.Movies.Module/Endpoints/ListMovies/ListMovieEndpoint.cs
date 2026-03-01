using CP.Portal.Movies.Module.Data.Domain;
using CP.Portal.Movies.Module.Services;
using FastEndpoints;

namespace CP.Portal.Movies.Module.Endpoints.ListMovies
{
    internal class ListMovieEndpoint(IMovieService movieService)
        : EndpointWithoutRequest<ListMovieResponse>
    {
        private readonly IMovieService _movieService = movieService;

        public override void Configure()
        {
            Get("/api/movies");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken cancellationToken=default) { 
            var movies = await _movieService.ListMovieAsync(cancellationToken);
            var moviesResponse = movies.Select(Movie => Movie.ToMovieResponse()).ToList();

            var response = new ListMovieResponse { Movies = moviesResponse };

            await Send.OkAsync(response, cancellationToken);
        }

    }
}

