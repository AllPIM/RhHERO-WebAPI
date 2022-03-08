namespace FSH.WebApi.Domain.FunCenter;

public class LuckyFruitIncome : AuditableEntity, IAggregateRoot
{
    public Guid LuckyFruitId { get; set; }
    public virtual LuckyFruit LuckyFruit { get; set; } = default!;

    public Guid OrderId { get; set; }
    public virtual Order Order { get; set; } = default!;
}

