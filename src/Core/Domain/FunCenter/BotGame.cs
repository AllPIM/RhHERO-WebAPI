namespace FSH.WebApi.Domain.FunCenter;

public class BotGame : AuditableEntity, IAggregateRoot
{
    public Guid GameId { get; private set; }
    public virtual Game Game { get; private set; } = default!;

    public int GameMode { get; set; }
}