using GoalLine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoalLine.DataAccess.Configurations;

internal class LeagueConfiguration : IEntityTypeConfiguration<League>
{
    public void Configure(EntityTypeBuilder<League> builder)
    {
        builder.HasData(
            new League { Id = 1, Title = "Persian Gulf Pro League" },
            new League { Id = 2, Title = "LaLiga" },
            new League { Id = 3, Title = "Premier League" }
            );
    }
}
