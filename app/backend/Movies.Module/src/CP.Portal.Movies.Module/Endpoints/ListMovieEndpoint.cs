using CP.Portal.Movies.Module.Services;
using FastEndpoints;

namespace CP.Portal.Movies.Module.Endpoints
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
            var movies = _movieService.GetMovies();
            var response = new ListMovieResponse { Movies = movies };

            await Send.OkAsync(response, cancellationToken);
        }

    }
}
