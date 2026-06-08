namespace LeagueManager.Api.Features.Teams
{
    public static class TeamsEndpoints
    {
        public static IEndpointRouteBuilder AddTeamsEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/teams").WithTags("Teams");

            group.MapGet("/", TeamsHandlers.GetAll);
            group.MapGet("/{id}", TeamsHandlers.GetById);
            group.MapPost("/", TeamsHandlers.Create);
            group.MapPut("/{id}", TeamsHandlers.Update);
            group.MapDelete("/{id}", TeamsHandlers.Delete);

            return app;
        }
    }
}