namespace FSH.WebApi.Application.FunCenter.LuckyBags;

public class LuckyBagDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}