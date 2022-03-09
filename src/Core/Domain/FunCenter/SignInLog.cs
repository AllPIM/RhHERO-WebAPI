namespace FSH.WebApi.Domain.FunCenter;

public class SignInLog : AuditableEntity, IAggregateRoot
{
    public Guid PlayerId { get; set; }
    public virtual Player Player { get; private set; } = default!;

    public string? Code { get; set; }
    public string? Token { get; set; }
    public OsType Os { get; set; }

    public string? Language { get; set; }
    public string? SceneName { get; set; }
    public string? SceneId { get; set; }
    public string? RoomId { get; set; }
    public string? IP { get; set; }

    public DateTime LoginOn { get; set; }
    public DateTime? LogoutOn { get; set; }
}
