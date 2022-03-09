namespace FSH.WebApi.Domain.FunCenter;

public class LuckyFruitReward : AuditableEntity, IAggregateRoot
{
    public Guid LuckyFruitId { get; set; }
    public virtual LuckyFruit LuckyFruit { get; private set; } = default!;

    public Guid OrderId { get; set; }
    public virtual Order Order { get; private set; } = default!;

    public int Spent { get; set; }
    public int Bonus { get; set; }
    public ActionStatus Status { get; set; }
}

