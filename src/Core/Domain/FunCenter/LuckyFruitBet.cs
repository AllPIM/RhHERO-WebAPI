namespace FSH.WebApi.Domain.FunCenter;

public class LuckyFruitBet : AuditableEntity, IAggregateRoot
{
    public Guid LuckyFruitId { get; set; }
    public virtual LuckyFruit LuckyFruit { get; set; } = default!;

    public Guid OrderId { get; set; }
    public virtual Order Order { get; set; } = default!;

    public OsType ChargeOs { get; set; }
    public int Chips { get; set; }
    public int Slot { get; set; }
}