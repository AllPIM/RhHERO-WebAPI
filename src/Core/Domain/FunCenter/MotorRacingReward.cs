namespace FSH.WebApi.Domain.FunCenter;

public class MotorRacingReward : AuditableEntity, IAggregateRoot
{
    public Guid MotorRacingId { get; set; }
    public virtual MotorRacing MotorRacing { get; set; } = default!;

    public Guid OrderId { get; set; }
    public virtual Order Order { get; set; } = default!;

    public int Spent { get; set; }
    public int Bonus { get; set; }
    public ActionStatus Status { get; set; }
}