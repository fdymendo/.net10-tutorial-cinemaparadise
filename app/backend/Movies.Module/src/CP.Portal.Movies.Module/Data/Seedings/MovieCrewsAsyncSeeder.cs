using CP.Portal.Movies.Module.Data.Domain;

using Microsoft.EntityFrameworkCore;

namespace CP.Portal.Movies.Module.Data.Seedings;

internal static class MovieCrewsAsyncSeeder
{
    public static async Task SeedAsync(
        MovieDbContext db, 
        IReadOnlyDictionary<string, Guid> movies, 
        CancellationToken ct
     )
    {
        if (await db.MovieCrews.AnyAsync(ct))
        {
            return;
        }

        var matrixId = movies["The Matrix"];
        var inceptionId = movies["Inception"];
        var avatarId = movies["Avatar"];

        await db.MovieCrews.AddRangeAsync(
            [
                new MovieCrew(matrixId, SeedConstants.PERSON_TARANTINO, "Director"),
                new MovieCrew(inceptionId, SeedConstants.PERSON_NOLAN, "Director"),
                new MovieCrew(avatarId, SeedConstants.PERSON_CAMERON, "Director"),
            ]
        , ct);

        await db.SaveChangesAsync(ct);

    }

}
