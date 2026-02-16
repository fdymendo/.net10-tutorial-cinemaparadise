using CP.Portal.Movies.Module;
using CP.Portal.Movies.Module.Movie.Service.Interface;
using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMovieService();
builder.Services.AddOpenApi();
builder.Services.AddFastEndpoints();

var app = builder.Build();

app.MapMoviesEndpoints();

app.UseFastEndpoints();

app.Run();