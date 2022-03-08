namespace FSH.WebApi.Domain.FunCenter;

public class Reward : AuditableEntity, IAggregateRoot
{
    public string? Action { get; private set; }
    public string? Description { get; private set; }

    public Guid TimelineId { get; private set; }
}
