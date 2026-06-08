namespace LeagueManager.Api.Features.Teams
{
    public static class TeamsHandlers
    {
        public static async Task<IResult> GetAll()
        {
            return Results.Ok();
        }

        public static async Task<IResult> GetById(Guid id)
        {
            return Results.Ok();
        }

        public static async Task<IResult> Create()
        {
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