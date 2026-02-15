using System;
using System.Collections.Generic;
using System.Text;

namespace CP.Portal.Movies.Module.Movie.Response
{
    public record MovieResponse(Guid Id, string Title, string Description);

    internal class Responses
    {
    }
}
