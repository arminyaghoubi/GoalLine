namespace GoalLine.Domain.Entities;

public class Match : BaseEntity
{
    public int HomeTeamId { get; set; }
    public int AwayTeamId { get; set; }
    public byte? CountOfHomeTeamGoals { get; set; }
    public byte? CountOfAwayTeamGoals { get; set; }
    public DateTime PlayDateTime { get; set; }
}