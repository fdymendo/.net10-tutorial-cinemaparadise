using CP.Portal.Movies.Module.Data;
using CP.Portal.Movies.Module.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CP.Portal.Movies.Module
{
    public static class MovieServiceExtensions
    {
        public static IServiceCollection AddMovieServices(this IServiceCollection services,
              ConfigurationManager config)
        {
            services.AddScoped<IMovieService, MovieService>();
            string? connectionString = config.GetConnectionString("MoviesConnectionString");
            services.AddDbContext<MovieDbContext>(opt =>
            {
                opt.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();

            });
            return services;
        }
    }
}
