namespace FSH.WebApi.Domain.FunCenter;

public class LuckyBag : AuditableEntity, IAggregateRoot
{
    public string Name { get; private set; }
    public string? Description { get; private set; }

    public IList<LuckyBagRobber>? LuckyBagRobbers { get; set; } = new List<LuckyBagRobber>();
    public IList<LuckyBagReturn>? LuckyBagReturns { get; set; } = new List<LuckyBagReturn>();

    public LuckyBag(string name, string? description)
    {
        Name = name;
        Description = description;
    }

    public LuckyBag Update(string? name, string? description)
    {
        if (name is not null && Name?.Equals(name) is not true) Name = name;
        if (description is not null && Description?.Equals(description) is not true) Description = description;
        return this;
    }
}