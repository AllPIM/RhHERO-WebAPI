namespace FSH.WebApi.Application.FunCenter.MotorRacings;

public class MotorRacingDetailDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}