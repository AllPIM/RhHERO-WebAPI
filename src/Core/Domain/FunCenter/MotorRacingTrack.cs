namespace FSH.WebApi.Domain.FunCenter;

public class MotorRacingTrack : AuditableEntity, IAggregateRoot
{
    public Guid MotorRacingId { get; private set; }
    public virtual MotorRacing MotorRacing { get; private set; } = default!;
}