namespace FSH.WebApi.Domain.FunCenter;

public class LogSignIn : AuditableEntity, IAggregateRoot
{
    public Guid PlayerId { get; set; }
    public virtual Player Player { get; private set; } = default!;

    public string? Code { get; set; }
    public string? Token { get; set; }
    public OsType Os { get; set; }

    public LanguageType Language { get; set; }
    public string? SceneName { get; set; }
    public string? SceneId { get; set; }
    public string? RoomId { get; set; }
    public string? IP { get; set; }

    public GameType? Game { get; set; }
    public int? Round { get; set; }

    public SignInType Type { get; set; }
}
