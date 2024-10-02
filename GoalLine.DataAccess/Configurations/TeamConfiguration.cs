using GoalLine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoalLine.DataAccess.Configurations;

public class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.HasData(
            new Team { Id = 1, Title = "Persepolis", CreatedDate = DateTime.UtcNow },
            new Team { Id = 2, Title = "Esteghlal F.C.", CreatedDate = DateTime.UtcNow },
            new Team { Id = 3, Title = "Malavan", CreatedDate = DateTime.UtcNow },
            new Team { Id = 4, Title = "Tractor", CreatedDate = DateTime.UtcNow },
            new Team { Id = 5, Title = "Sepahan", CreatedDate = DateTime.UtcNow },
            new Team { Id = 6, Title = "Foolad", CreatedDate = DateTime.UtcNow },
            new Team { Id = 7, Title = "Gol Gohar", CreatedDate = DateTime.UtcNow },
            new Team { Id = 8, Title = "Chadormalu", CreatedDate = DateTime.UtcNow },
            new Team { Id = 9, Title = "Zob Ahan", CreatedDate = DateTime.UtcNow },
            new Team { Id = 10, Title = "Esteghlal Khuzestan", CreatedDate = DateTime.UtcNow },
            new Team { Id = 11, Title = "Aluminium Arak", CreatedDate = DateTime.UtcNow },
            new Team { Id = 12, Title = "Mes Rafsanjan", CreatedDate = DateTime.UtcNow },
            new Team { Id = 13, Title = "Kheybar", CreatedDate = DateTime.UtcNow },
            new Team { Id = 14, Title = "Nassaji Mazandaran", CreatedDate = DateTime.UtcNow },
            new Team { Id = 15, Title = "Shams Azar", CreatedDate = DateTime.UtcNow },
            new Team { Id = 16, Title = "Havadar", CreatedDate = DateTime.UtcNow }
            );
    }
}
