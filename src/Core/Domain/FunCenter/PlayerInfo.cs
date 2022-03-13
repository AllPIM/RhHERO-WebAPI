namespace FSH.WebApi.Domain.FunCenter;

public class PlayerInfo : AuditableEntity, IAggregateRoot
{
    public Guid PlayerId { get; set; }

    public string? NickName { get; set; }
    public string? Avatar { get; set; }

    public int? Level { get; set; }
    public string? LevelDate { get; set; }
    public int? Rank { get; set; }
    public string? RankDate { get; set; }
    public string? MBIT { get; set; }
    public string? MBITDate { get; set; }
    public int? Experience { get; set; }
    public string? ExpDate { get; set; }
}