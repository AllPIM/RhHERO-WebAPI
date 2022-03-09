namespace FSH.WebApi.Domain.FunCenter;

public class Order : AuditableEntity, IAggregateRoot
{
    public Guid PlayerId { get; set; }
    public virtual Player Player { get; private set; } = default!;

    public IList<MotorRacingBet>? MotorRacingBets { get; set; } = new List<MotorRacingBet>();
    public IList<MotorRacingReward>? MotorRacingRewards { get; set; } = new List<MotorRacingReward>();

    public IList<LuckyFruitBet>? LuckyFruitBets { get; set; } = new List<LuckyFruitBet>();
    public IList<LuckyFruitReward>? LuckyFruitRewards { get; set; } = new List<LuckyFruitReward>();

    public IList<LuckyBagRobber>? LuckyBagRobbers { get; set; } = new List<LuckyBagRobber>();
    public IList<LuckyBagReturn>? LuckyBagReturns { get; set; } = new List<LuckyBagReturn>();

    public IList<Payment>? Payments { get; set; } = new List<Payment>();
}