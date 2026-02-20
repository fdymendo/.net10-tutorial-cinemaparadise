using Microsoft.Extensions.DependencyInjection;

namespace CP.Portal.Movies.Module.Services
{
    public static class MovieServiceExtensions
    {
        public static IServiceCollection AddMovieService(this IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();

            return services;
        }
    }
}
