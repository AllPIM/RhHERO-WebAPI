namespace FSH.WebApi.Domain.FunCenter;

public class MotorRacing : AuditableEntity, IAggregateRoot
{
    public string Name { get; private set; }
    public string? Description { get; private set; }

    public IList<MotorRacingBet>? MotorRacingBets { get; set; } = new List<MotorRacingBet>();
    public IList<MotorRacingReward>? MotorRacingRewards { get; set; } = new List<MotorRacingReward>();

    public MotorRacing(string name, string? description)
    {
        Name = name;
        Description = description;
    }

    public MotorRacing Update(string? name, string? description)
    {
        if (name is not null && Name?.Equals(name) is not true) Name = name;
        if (description is not null && Description?.Equals(description) is not true) Description = description;
        return this;
    }
}