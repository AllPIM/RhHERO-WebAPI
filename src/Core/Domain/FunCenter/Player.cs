namespace FSH.WebApi.Domain.FunCenter;

public class Player : AuditableEntity, IAggregateRoot
{
    public string? Name { get; set; }
    public PlayerStatus Status { get; set; }
    public PlayerTag Tag { get; set; }

    public IList<PlayerBalance>? PlayerBalances { get; set; } = new List<PlayerBalance>();
    public IList<Timeline>? Timelines { get; set; } = new List<Timeline>();
    public IList<Order>? Orders { get; set; } = new List<Order>();
    public IList<SignInLog>? SignInLogs { get; set; } = new List<SignInLog>();
}