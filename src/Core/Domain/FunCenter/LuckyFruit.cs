namespace FSH.WebApi.Domain.FunCenter;

public class LuckyFruit : AuditableEntity, IAggregateRoot
{
    public string? ReportDate { get; set; }
    public int? Round { get; set; }
    public int? Fee { get; set; }
    public int? Mode { get; set; }
    public int? Slots { get; set; }
    public int? Winner { get; set; }

    public IList<LuckyFruitBet>? LuckyFruitBets { get; set; } = new List<LuckyFruitBet>();
    public IList<LuckyFruitReward>? LuckyFruitRewards { get; set; } = new List<LuckyFruitReward>();
    public IList<LuckyFruitIncome>? LuckyFruitIncomes { get; set; } = new List<LuckyFruitIncome>();
    public IList<LuckyFruitTrack>? LuckyFruitTracks { get; set; } = new List<LuckyFruitTrack>();
}