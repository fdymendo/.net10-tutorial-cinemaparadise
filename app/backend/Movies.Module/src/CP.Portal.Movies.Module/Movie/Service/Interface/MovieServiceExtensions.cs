using CP.Portal.Movies.Module.Movie.Service.Interface.Impl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CP.Portal.Movies.Module.Movie.Service.Interface
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
