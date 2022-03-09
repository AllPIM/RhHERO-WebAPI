namespace FSH.WebApi.Domain.FunCenter;

public class MotorRacingTrack : AuditableEntity, IAggregateRoot
{
    public Guid MotorRacingId { get; private set; }
    public virtual MotorRacing MotorRacing { get; private set; } = default!;

    public int? Track { get; set; }
    public int? Motions { get; set; }

    public string? Speeds { get; set; }
    public string? Lapses { get; set; }
    public string? Seconds { get; set; }
}