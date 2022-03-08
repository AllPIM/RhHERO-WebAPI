namespace FSH.WebApi.Domain.FunCenter;

public class PlayerBalance : AuditableEntity, IAggregateRoot
{
    public Guid PlayerId { get; private set; }
    public virtual Player Player { get; private set; } = default!;

    public OsType Os { get; set; }
    public int? Balance { get; set; }
}
