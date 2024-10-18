namespace GoalLine.Domain.Entities;

public class Team : BaseEntity
{
    public string? Title { get; set; }
    public int LeagueId { get; set; }
    public int CoachId { get; set; }
}