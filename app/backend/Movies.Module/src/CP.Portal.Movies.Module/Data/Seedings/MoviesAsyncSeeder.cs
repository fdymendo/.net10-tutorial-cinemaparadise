using CP.Portal.Movies.Module.Data.Domain;

using Microsoft.EntityFrameworkCore;

namespace CP.Portal.Movies.Module.Data.Seedings;

internal static class MoviesAsyncSeeder
{
    public static async Task<Dictionary<string, Guid>> SeedAsync(
        MovieDbContext db,
        CancellationToken ct
    )
    { 
        var map = new Dictionary<string, Guid>(StringComparer.OrdinalIgnoreCase);

        if (await db.Movies.AnyAsync(ct))
        {
            var moviesFromDb = await db.Movies
                .Select(m => new { m.Title, m.MovieId})
                .ToListAsync(ct);

            foreach(var e in moviesFromDb)
                map[e.Title] = e.MovieId;

            return map;
        }


        var m1 = new Movie(
            "The Matrix",
            new DateOnly(1999,1,1),
            136,
            "en",
            12.34m,
            "Hacker discover a new reality"
            );

        var m2 = new Movie(
            "Inception",
            new DateOnly(2010, 1, 1),
            155,
            "en",
            15.25m,
            "It is about dreams"
            );

        var m3 = new Movie(
            "Avatar",
            new DateOnly(2009, 1, 1),
            200,
            "en",
            20.15m,
            "It is about Aliens"
            );

        await db.Movies.AddRangeAsync([m1, m2, m3], ct);
        await db.SaveChangesAsync(ct);

        map[m1.Title] = m1.MovieId;
        map[m2.Title] = m2.MovieId;
        map[m3.Title] = m3.MovieId;

        return map;
    }

}