using CP.Portal.Movies.Module;
using CP.Portal.Movies.Module.Services;
using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMovieServices(builder.Configuration);
builder.Services.AddOpenApi();
builder.Services.AddFastEndpoints();

var app = builder.Build();

app.UseFastEndpoints();

app.Run();