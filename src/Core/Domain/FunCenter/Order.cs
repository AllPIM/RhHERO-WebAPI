namespace FSH.WebApi.Domain.FunCenter;

public class Order : AuditableEntity, IAggregateRoot
{
    public Guid PlayerId { get; set; }
    public virtual Player Player { get; private set; } = default!;

    public Game Game { get; set; }
    public OsType ChargeOs { get; set; }

    public IList<MotorRacingBet>? MotorRacingBets { get; set; } = new List<MotorRacingBet>();
    public IList<MotorRacingReward>? MotorRacingRewards { get; set; } = new List<MotorRacingReward>();
    public IList<MotorRacingIncome>? MotorRacingIncomes { get; set; } = new List<MotorRacingIncome>();

    public IList<LuckyFruitBet>? LuckyFruitBets { get; set; } = new List<LuckyFruitBet>();
    public IList<LuckyFruitReward>? LuckyFruitRewards { get; set; } = new List<LuckyFruitReward>();
    public IList<LuckyFruitIncome>? LuckyFruitIncomes { get; set; } = new List<LuckyFruitIncome>();

    public IList<Payment>? Payments { get; set; } = new List<Payment>();
}