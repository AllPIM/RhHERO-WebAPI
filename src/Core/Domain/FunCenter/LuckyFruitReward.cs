namespace FSH.WebApi.Domain.FunCenter;

public class LuckyFruitReward : AuditableEntity, IAggregateRoot
{
    public Guid OrderId { get; set; }
    public virtual Order Order { get; set; } = default!;

    public Guid LuckyFruitId { get; set; }
    public virtual LuckyFruit LuckyFruit { get; set; } = default!;
}

