namespace FSH.WebApi.Application.WholeGame.MotorRacings;

public class MotorRacingDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}