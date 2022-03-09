namespace FSH.WebApi.Domain.FunCenter;

public class PlayerInfo : AuditableEntity, IAggregateRoot
{
    public Guid PlayerId { get; set; }
    public virtual Player Player { get; private set; } = default!;

    public string? Name { get; set; }
    public string? NickName { get; set; }
    public string? Avatar { get; set; }
    public OsType Os { get; set; }
    public UserType Type { get; set; }
}