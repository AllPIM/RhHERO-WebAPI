namespace FSH.WebApi.Domain.FunCenter;

public class Timeline : AuditableEntity, IAggregateRoot
{
    public Guid PlayerId { get; set; }
    public virtual Player Player { get; private set; } = default!;

    public string? Name { get; set; }
    public string? Description { get; set; }

    public UserType Type { get; set; }

    public IList<Reward>? Rewards { get; set; } = new List<Reward>();

}
