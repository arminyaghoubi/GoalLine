using GoalLine.DataAccess.Contexts;
using GoalLine.Domain.Entities;
using Microsoft.EntityFrameworkCore;

using LeagueDbContext context = new();

//await GetAllTeams();
//await GetSearchTeamsQuerySyntax("Per");
//await GetOneTeam();
//await GetFilteredTeams();
//await AggregateMethods();
//await GroupByMethod();
//await OrderByMethods();
//await SkipAndTake();
//await ProjectionsAndSelect();
//await NoTracking();
//await ListVsQueryable();

async Task GetAllTeams()
{
    var teams = await context.Teams
        .AsNoTracking()
        .ToListAsync();

    foreach (var team in teams)
    {
        Console.WriteLine($"{team.Id} - {team.Title}");
    }
}

async Task GetSearchTeamsQuerySyntax(string term)
{
    var teams = await (from team in context.Teams
                       where EF.Functions.Like(team.Title, $"%{term}%")
                       select team)
                       .AsNoTracking()
                       .ToListAsync();

    Console.WriteLine($"Search Term: {term}");
    foreach (var team in teams)
    {
        Console.WriteLine($"{team.Id} - {team.Title}");
    }
}

async Task GetOneTeam()
{
    var firstTeam = await context.Teams
        .AsNoTracking()
        .FirstAsync();
    Console.WriteLine($"First Team is {firstTeam.Title}");

    var firstCoachOrDefault = await context.Coaches
        .AsNoTracking()
        .FirstOrDefaultAsync();
    if (firstCoachOrDefault is not null)
    {
        Console.WriteLine($"First Coach is {firstCoachOrDefault.FirstName} {firstCoachOrDefault.LastName}");
    }

    var firstTeamWithCondition = await context.Teams
        .AsNoTracking()
        .FirstAsync(t => t.Id == 5);
    Console.WriteLine($"ID 5 is {firstTeamWithCondition.Title}");

    var signleTeamWithCondition = await context.Teams
        .AsNoTracking()
        .SingleAsync(t => t.Id == 5);
    Console.WriteLine($"ID 5 is {signleTeamWithCondition.Title}");

    var signleOrDefaultTeamWithCondition = await context.Teams
        .AsNoTracking()
        .SingleOrDefaultAsync(t => t.Id == 5);
    if (signleOrDefaultTeamWithCondition is not null)
    {
        Console.WriteLine($"ID 5 is {signleOrDefaultTeamWithCondition.Title}");
    }

    var teamWithId = await context.Teams.FindAsync(5);
    if (teamWithId is not null)
    {
        Console.WriteLine($"ID 5 is {teamWithId.Title}");
    }
}

async Task GetFilteredTeams()
{
    Console.Write("Enter search term: ");
    string term = Console.ReadLine();

    Console.WriteLine("===========Equal===========");
    var teamsFiltered = await context.Teams
        .AsNoTracking()
        .Where(t => t.Title == term)
        .ToListAsync();
    foreach (var team in teamsFiltered)
    {
        Console.WriteLine($"{team.Id} - {team.Title}");
    }

    Console.WriteLine("===========Contains===========");
    var partialMaches = await context.Teams
        .AsNoTracking()
        .Where(t => t.Title.Contains(term))
        .ToListAsync();
    foreach (var team in partialMaches)
    {
        Console.WriteLine($"{team.Id} - {team.Title}");
    }

    Console.WriteLine("===========EF Function===========");
    var partialMachesLike = await context.Teams
        .AsNoTracking()
        .Where(t => EF.Functions.Like(t.Title,$"%{term}%"))
        .ToListAsync();
    foreach (var team in partialMachesLike)
    {
        Console.WriteLine($"{team.Id} - {team.Title}");
    }
}

async Task AggregateMethods()
{
    var countOfTeams = await context.Teams.CountAsync();
    Console.WriteLine($"Count of teams {countOfTeams}");

    var countOfTeamsWithCondition=await context.Teams.CountAsync(t=>t.Title.Contains("F.C"));
    Console.WriteLine($"Count of teams with condition {countOfTeamsWithCondition}");

    var maxId = await context.Teams.MaxAsync(t=>t.Id);
    Console.WriteLine($"Max by id {maxId}");

    var minId = await context.Teams.MinAsync(t => t.Id);
    Console.WriteLine($"Max by id {minId}");

    var averageId = await context.Teams.AverageAsync(t => t.Id);
    Console.WriteLine($"Average id {averageId}");

    var totalId = await context.Teams.SumAsync(t => t.Id);
    Console.WriteLine($"Sum id {totalId}");
}

async Task GroupByMethod()
{
    var groupedTeams = await context.Teams
        .GroupBy(t => t.CreatedDate.Date)
        .ToListAsync();

    foreach (var group in groupedTeams)
    {
        Console.WriteLine($"- {group.Key}");
        foreach (var team in group)
        {
            Console.WriteLine($"\t{team.Title}");
        }
    }
}

async Task OrderByMethods()
{
    Console.WriteLine("===========Order By===========");
    var orderedTeams = await context.Teams
        .AsNoTracking()
        .OrderBy(t => t.Title)
        .ToListAsync();
    foreach (var team in orderedTeams)
    {
        Console.WriteLine($"{team.Id} - {team.Title}");
    }

    Console.WriteLine("===========Order By Desc===========");
    var descOrderedTeams = await context.Teams
        .AsNoTracking()
        .OrderByDescending(t => t.Title)
        .ToListAsync();
    foreach (var team in descOrderedTeams)
    {
        Console.WriteLine($"{team.Id} - {team.Title}");
    }
}

async Task SkipAndTake()
{
    int page = 1;
    int pageSize = 10;

    var teams = await context.Teams
        .AsNoTracking()
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToListAsync();

    foreach (var team in teams)
    {
        Console.WriteLine($"{team.Id} - {team.Title}");
    }
}

async Task ProjectionsAndSelect()
{
    var teams = await context.Teams
        .AsNoTracking()
        .Select(t => new TeamInfo { TeamId = t.Id, Title = t.Title })
        .ToListAsync();
    foreach (var team in teams)
    {
        Console.WriteLine($"{team.TeamId} - {team.Title}");
    }
}

async Task NoTracking()
{
    var teams = await context.Teams
        .AsNoTracking()
        .ToListAsync();

    foreach (var t in teams)
    {
        Console.WriteLine(t.Title);
    }
}

async Task ListVsQueryable()
{
    Console.WriteLine("Enter '1' for Team with Id 1 or '2' for teams that contain 'F.C.'");
    var option = Convert.ToInt32(Console.ReadLine());
    List<Team> teamsAsList = new List<Team>();

    // After executing to ToListAsync, the records are loaded into memory. Any operation is then done in memory
    teamsAsList = await context.Teams.ToListAsync();
    if (option == 1)
    {
        teamsAsList = teamsAsList.Where(q => q.Id == 1).ToList();
    }
    else if (option == 2)
    {
        teamsAsList = teamsAsList.Where(q => q.Title.Contains("F.C.")).ToList();
    }

    foreach (var t in teamsAsList)
    {
        Console.WriteLine(t.Title);
    }

    // Records stay as IQueryable until the ToListAsync is executed, then the final query is performed. 
    var teamsAsQueryable = context.Teams.AsQueryable();
    if (option == 1)
    {
        teamsAsQueryable = teamsAsQueryable.Where(team => team.Id == 1);
    }

    if (option == 2)
    {
        teamsAsQueryable = teamsAsQueryable.Where(team => team.Title.Contains("F.C"));
    }

    // Actual Query execution
    teamsAsList = await teamsAsQueryable.ToListAsync();
    foreach (var t in teamsAsList)
    {
        Console.WriteLine(t.Id);
    }

}

// DTO
class TeamInfo
{
    public int TeamId { get; set; }
    public string Title { get; set; }
}