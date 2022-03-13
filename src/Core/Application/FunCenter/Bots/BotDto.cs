namespace FSH.WebApi.Application.FunCenter.Bots;

public class BotDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}