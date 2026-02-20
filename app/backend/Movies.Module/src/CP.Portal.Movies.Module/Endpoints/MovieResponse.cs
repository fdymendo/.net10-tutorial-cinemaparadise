using System;
using System.Collections.Generic;
using System.Text;

namespace CP.Portal.Movies.Module.Endpoints
{
    public record MovieResponse(Guid Id, string Title, string Description);

}
