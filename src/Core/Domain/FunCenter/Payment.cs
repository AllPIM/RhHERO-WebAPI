namespace FSH.WebApi.Domain.FunCenter;

public class Payment : AuditableEntity, IAggregateRoot
{
    public Guid OrderId { get; set; }
    public virtual Order Order { get; set; } = default!;
}