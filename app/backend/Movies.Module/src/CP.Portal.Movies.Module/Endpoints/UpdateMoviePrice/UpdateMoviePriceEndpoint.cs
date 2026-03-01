
using CP.Portal.Movies.Module.Core;
using CP.Portal.Movies.Module.Services;

namespace CP.Portal.Movies.Module.Endpoints.UpdateMoviePrice;

internal class UpdateMoviePriceEndpoint(IMovieService movieService) : ValidatedEndpoint<UpdateMoviePriceRequest>
{
    private readonly IMovieService _movieService = movieService;

    public override void Configure()
    {
        Put("/api/movies/{Id}/price");
        AllowAnonymous();
    }

    protected override async Task OnValidatedAsync(
        UpdateMoviePriceRequest request, 
        CancellationToken ct)
    {
        await _movieService.UpdateMoviePriceAsync(request.Id, request.NewPrice,ct);
        await Send.NoContentAsync();
    }

}

internal sealed class UpdateMoviePriceRequestValidator : IValidator<UpdateMoviePriceRequest>
{
    public IEnumerable<ValidationError> Validate(UpdateMoviePriceRequest request)
    {

        if (request.NewPrice <= 0)
        {
            yield return new ValidationError(
                nameof(request.NewPrice), 
                "Price needs to be more than zero"
            );
        }

    }
}

public class UpdateMoviePriceRequest
{ 
    public Guid Id { get; set; }
    public decimal NewPrice { get; set; }
}
