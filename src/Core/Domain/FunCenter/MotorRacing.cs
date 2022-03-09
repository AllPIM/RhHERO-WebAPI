namespace FSH.WebApi.Domain.FunCenter;

public class MotorRacing : AuditableEntity, IAggregateRoot
{
    public string? ReportDate { get; set; }
    public int? Round { get; set; }
    public int? Fee { get; set; }
    public int? Tracks { get; set; }
    public int? Winner { get; set; }

    public IList<MotorRacingBet>? MotorRacingBets { get; set; } = new List<MotorRacingBet>();
    public IList<MotorRacingReward>? MotorRacingRewards { get; set; } = new List<MotorRacingReward>();
    public IList<MotorRacingIncome>? MotorRacingIncomes { get; set; } = new List<MotorRacingIncome>();
    public IList<MotorRacingTrack>? MotorRacingTracks { get; set; } = new List<MotorRacingTrack>();
}