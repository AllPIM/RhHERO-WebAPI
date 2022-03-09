namespace FSH.WebApi.Domain.FunCenter;

public class Bot : AuditableEntity, IAggregateRoot
{
    public Guid PlayerId { get; set; }
    public virtual Player Player { get; private set; } = default!;

    public OsType? AccessOs { get; set; }
    public string? AccessCode { get; set; }
    public StartType StartType { get; set; }

    public IList<BotGame>? BotGames { get; set; } = new List<BotGame>();
}