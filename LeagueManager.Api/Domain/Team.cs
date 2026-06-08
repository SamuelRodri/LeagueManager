namespace LeagueManager.Api.Domain
{
    public class Team
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}