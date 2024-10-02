using GoalLine.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoalLine.DataAccess.Contexts;

public class LeagueDbContext : DbContext
{
    private string _databasePath;

    public LeagueDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        _databasePath = Path.Combine(path, "League.db");
    }

    public DbSet<Team> Teams { get; set; }
    public DbSet<Coach> Coaches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={_databasePath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
