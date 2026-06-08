using LeagueManager.Api.Data;
using LeagueManager.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace LeagueManager.Api.Features.Teams
{
    public class TeamsService
    {
        private readonly ApplicationDbContext _dbContext;
        public TeamsService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<ICollection<Team>> GetAll()
        {
            return await _dbContext.Teams.ToListAsync();
        }

        public async Task<Team?> GetById(Guid id)
        {
            return await _dbContext.Teams.FindAsync(id);
        }

        public async Task Create(Team team)
        {
            _dbContext.Teams.Add(team);
            await _dbContext.SaveChangesAsync();
        }
    }
}