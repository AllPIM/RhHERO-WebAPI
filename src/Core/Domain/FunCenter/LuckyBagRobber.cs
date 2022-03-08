namespace FSH.WebApi.Domain.FunCenter;

public class LuckyBagRobber : AuditableEntity, IAggregateRoot
{
    public Guid OrderId { get; set; }
    public virtual Order Order { get; set; } = default!;

    public Guid LuckyBagId { get; set; }
    public virtual LuckyBag LuckyBag { get; set; } = default!;
}

