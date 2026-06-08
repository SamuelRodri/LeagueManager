using LeagueManager.Api.Data;
using LeagueManager.Api.Features.Teams;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("LeagueManagerDb"));

builder.Services.AddScoped<TeamsService>();


var app = builder.Build();
var api = app.MapGroup("/api");

api.AddTeamsEndpoints();

app.Run();