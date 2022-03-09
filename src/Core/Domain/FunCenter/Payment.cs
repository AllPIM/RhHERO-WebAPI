namespace FSH.WebApi.Domain.FunCenter;

public class Payment : AuditableEntity, IAggregateRoot
{
    public Guid OrderId { get; set; }
    public virtual Order Order { get; set; } = default!;

    public string? Name { get; set; }
    public OsType ChargeOs { get; set; }
    public Game Game { get; set; }
    public string? ReportDate { get; set; }
    public int? Round { get; set; }

    public OperatorType Operator { get; set; }
    public ReasonType Reason { get; set; }
    public int Amount { get; set; }
    public ActionStatus Status { get; set; }
    public int? Balance { get; set; }
}