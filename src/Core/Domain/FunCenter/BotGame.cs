namespace FSH.WebApi.Domain.FunCenter;

public class BotGame : AuditableEntity, IAggregateRoot
{
    public Guid BotId { get; set; }
    public virtual Bot Bot { get; private set; } = default!;

    public Game Game { get; set; }
    public int GameMode { get; set; }
}