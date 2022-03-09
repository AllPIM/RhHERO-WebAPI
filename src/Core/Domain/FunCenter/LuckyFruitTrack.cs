namespace FSH.WebApi.Domain.FunCenter;

public class LuckyFruitTrack : AuditableEntity, IAggregateRoot
{
    public Guid LuckyFruitId { get; set; }
    public virtual LuckyFruit LuckyFruit { get; set; } = default!;

    public string? Odds { get; set; }
    public string? Chances { get; set; }
}

