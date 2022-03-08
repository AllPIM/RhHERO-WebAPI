namespace FSH.WebApi.Domain.FunCenter;

public class Bot : AuditableEntity, IAggregateRoot
{
    public string? Name { get; set; }
    public Guid PlayerId { get; set; }
    public virtual Player Player { get; private set; } = default!;

    public OsType? AccessOs { get; set; }
    public string? AccessToken { get; set; }

    public StartType StartType { get; set; }
    public ActiveStatus Status { get; set; }

    public int? iOSBalance { get; set; }
    public int? AndroidBalance { get; set; }
    public DateTime? LastQueried { get; set; }

    public IList<BotGame>? BotGames { get; set; } = new List<BotGame>();
}

