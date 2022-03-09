namespace FSH.WebApi.Domain.FunCenter;

public class MotorRacingBet : AuditableEntity, IAggregateRoot
{
    public Guid MotorRacingId { get; set; }
    public virtual MotorRacing MotorRacing { get; set; } = default!;

    public Guid OrderId { get; set; }
    public virtual Order Order { get; set; } = default!;

    public OsType ChargeOs { get; set; }
    public int Chips { get; set; }
    public int Track { get; set; }
}