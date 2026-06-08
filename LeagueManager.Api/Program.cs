using LeagueManager.Api.Features.Teams;

var app = WebApplication.Create(args);

var api = app.MapGroup("/api");

api.AddTeamsEndpoints();

app.Run();