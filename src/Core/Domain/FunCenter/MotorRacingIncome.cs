namespace FSH.WebApi.Domain.FunCenter;

public class MotorRacingIncome : AuditableEntity, IAggregateRoot
{
    public Guid MotorRacingId { get; set; }
    public virtual MotorRacing MotorRacing { get; set; } = default!;

    public Guid OrderId { get; set; }
    public virtual Order Order { get; set; } = default!;

    public int TotalBets { get; set; }
    public int TotalRewards { get; set; }
    public int Benefits { get; set; }
    public ActionStatus Status { get; set; }
}

