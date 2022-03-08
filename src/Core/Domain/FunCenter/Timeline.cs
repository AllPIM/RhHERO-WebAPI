namespace FSH.WebApi.Domain.FunCenter;

public class Timeline : AuditableEntity, IAggregateRoot
{
    public string? Name { get; set; }
    public string? Description { get; private set; }

    public UserType Type { get; set; }

    public IList<Reward>? Rewards { get; set; } = new List<Reward>();

}
