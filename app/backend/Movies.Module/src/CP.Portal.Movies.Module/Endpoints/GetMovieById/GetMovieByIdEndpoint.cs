using CP.Portal.Movies.Module.Services;

using FastEndpoints;

namespace CP.Portal.Movies.Module.Endpoints.GetMovieById;

public class GetMovieByIdRequest
{ 
    public Guid Id { get; set; }
}

internal class GetMovieByIdEndpoint(IMovieService movieService)
    : Endpoint<GetMovieByIdRequest, MovieResponse>
{
    private readonly IMovieService _movieService = movieService;

    public override void Configure()
    {
        Get("/api/movies/{Id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetMovieByIdRequest req, CancellationToken ct)
    {
        var movie = await _movieService.GetMovieByIdAsync(req.Id, ct);
        if (movie is null)
        {
            await Send.NotFoundAsync(ct);
            return;
        }

        await Send.OkAsync(movie!.ToMovieResponse(), ct);
    }
}
