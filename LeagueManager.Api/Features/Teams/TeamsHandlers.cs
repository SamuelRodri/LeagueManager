using LeagueManager.Api.Domain;

namespace LeagueManager.Api.Features.Teams
{
    public static class TeamsHandlers
    {
        public static async Task<IResult> GetAll(TeamsService teamsService)
        {
            var teams = await teamsService.GetAll();
            return Results.Ok(teams);
        }

        public static async Task<IResult> GetById(Guid id)
        {
            return Results.Ok();
        }

        public static async Task<IResult> Create(Team team, TeamsService teamsService)
        {
            await teamsService.Create(team);
            return Results.Created();
        }

        public static async Task<IResult> Update()
        {
            return Results.NoContent();
        }

        public static async Task<IResult> Delete(Guid id)
        {
            return Results.NoContent();
        }
    }
}