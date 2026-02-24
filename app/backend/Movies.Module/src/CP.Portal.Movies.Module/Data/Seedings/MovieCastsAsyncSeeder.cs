using CP.Portal.Movies.Module.Data.Domain;

using Microsoft.EntityFrameworkCore;

namespace CP.Portal.Movies.Module.Data.Seedings;

internal static class MovieCastsAsyncSeeder
{
    public static async Task SeedAsync(MovieDbContext db,
        IReadOnlyDictionary<string, Guid> movies,
        CancellationToken ct
    )
    {
        if (await db.MovieCasts.AnyAsync(ct))
        {
            return;
        }

        var matrixId = movies["The Matrix"];
        var inceptionId = movies["Inception"];


        await db.MovieCasts.AddRangeAsync(
            [
            new MovieCast(matrixId, SeedConstants.PERSON_KEANU, "Neo", 1),
            new MovieCast(matrixId, SeedConstants.PERSON_MOSS, "Trinity", 2),
            new MovieCast(inceptionId, SeedConstants.PERSON_LEO, "Cobb", 1)
            ], ct
        );

        await db.SaveChangesAsync(ct);
    }
}
