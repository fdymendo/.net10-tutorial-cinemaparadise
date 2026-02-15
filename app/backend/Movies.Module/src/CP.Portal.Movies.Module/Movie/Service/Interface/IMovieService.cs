using CP.Portal.Movies.Module.Movie.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace CP.Portal.Movies.Module.Movie.Service.Interface
{
    internal interface IMovieService
    {
        List<MovieResponse> GetMovie();

    }
}
