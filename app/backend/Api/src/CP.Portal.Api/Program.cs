using CP.Portal.Movies.Module;
using CP.Portal.Movies.Module.Movie.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMovieService();
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapMoviesEndpoints();


app.Run();