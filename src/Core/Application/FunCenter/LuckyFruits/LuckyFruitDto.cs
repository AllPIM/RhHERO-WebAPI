namespace FSH.WebApi.Application.FunCenter.LuckyFruits;

public class LuckyFruitDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}