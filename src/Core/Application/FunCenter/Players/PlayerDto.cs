namespace FSH.WebApi.Application.FunCenter.Players;

public class PlayerDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public PlayerStatus Status { get; set; }
    public PlayerTag Tag { get; set; }

    public Guid PlayerInfoId { get; set; }
    public virtual PlayerInfo PlayerInfo { get; private set; } = default!;

    public IList<PlayerBalance>? PlayerBalances { get; set; } = new List<PlayerBalance>();
    public IList<SignInLog>? SignInLogs { get; set; } = new List<SignInLog>();
}