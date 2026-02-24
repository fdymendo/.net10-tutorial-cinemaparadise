using CP.Portal.Movies.Module.Data.Domain;

namespace CP.Portal.Movies.Module.Data.Repositories;

internal interface IReadOnlyMovieRepository
{
    Task<Movie?> GetByIdAsync(Guid id, CancellationToken ct);
    Task<List<Movie>> ListAsync(CancellationToken ct);
}
