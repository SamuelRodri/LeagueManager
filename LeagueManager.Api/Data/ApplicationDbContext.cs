using LeagueManager.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace LeagueManager.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        
        public DbSet<Team> Teams { get; set; }
    }
}