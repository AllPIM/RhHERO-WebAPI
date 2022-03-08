namespace FSH.WebApi.Domain.FunCenter;

public class Player : AuditableEntity, IAggregateRoot
{
    public string? Name { get; set; }
    public string? NickName { get; set; }
    public string? Avatar { get; set; }
    public OsType Os { get; set; }
    public UserType Type { get; set; }

    public IList<PlayerBalance>? PlayerBalances { get; set; } = new List<PlayerBalance>();
    public IList<Timeline>? Timelines { get; set; } = new List<Timeline>();
    public IList<Order>? Orders { get; set; } = new List<Order>();
    public IList<LogSignIn>? LogSignIns { get; set; } = new List<LogSignIn>();
}