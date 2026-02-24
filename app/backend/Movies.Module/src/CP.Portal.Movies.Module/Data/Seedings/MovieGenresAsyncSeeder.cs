using CP.Portal.Movies.Module.Data.Domain;

using Microsoft.EntityFrameworkCore;

namespace CP.Portal.Movies.Module.Data.Seedings;

internal static class MovieGenresAsyncSeeder
{
    public static async Task SeedAsync(
        MovieDbContext db, 
        IReadOnlyDictionary<string, Guid> movies, 
        CancellationToken ct
     )
    {
        if (await db.MovieGenres.AnyAsync(ct))
            return;

        var matrixId = movies["The Matrix"];
        var inceptionId = movies["Inception"];
        var avatarId = movies["Avatar"];

        await db.MovieGenres.AddRangeAsync(
            [
                new MovieGenre(matrixId, SeedConstants.GENRE_SCIFI),
                new MovieGenre(matrixId, SeedConstants.GENRE_ACTION),

                new MovieGenre(inceptionId, SeedConstants.GENRE_SCIFI),
                new MovieGenre(inceptionId, SeedConstants.GENRE_THRILLER),

                new MovieGenre(avatarId, SeedConstants.GENRE_SCIFI),
                new MovieGenre(avatarId, SeedConstants.GENRE_FANTASY),
            ], ct
        );

        await db.SaveChangesAsync(ct);

    }
}
