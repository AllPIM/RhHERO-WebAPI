using System.Collections.ObjectModel;

namespace FSH.WebApi.Shared.Authorization;

public static class FSHAction
{
    public const string View = nameof(View);
    public const string Search = nameof(Search);
    public const string Create = nameof(Create);
    public const string Update = nameof(Update);
    public const string Delete = nameof(Delete);
    public const string Export = nameof(Export);
    public const string Generate = nameof(Generate);
    public const string Clean = nameof(Clean);
    public const string UpgradeSubscription = nameof(UpgradeSubscription);
}

public static class FSHResource
{
    public const string Tenants = nameof(Tenants);
    public const string Dashboard = nameof(Dashboard);
    public const string Hangfire = nameof(Hangfire);
    public const string Users = nameof(Users);
    public const string UserRoles = nameof(UserRoles);
    public const string Roles = nameof(Roles);
    public const string RoleClaims = nameof(RoleClaims);
    public const string Products = nameof(Products);
    public const string Brands = nameof(Brands);

    public const string Players = nameof(Players);
    public const string Bots = nameof(Bots);
    public const string MotorRacings = nameof(MotorRacings);
    public const string LuckyFruits = nameof(LuckyFruits);
    public const string LuckyBags = nameof(LuckyBags);
    public const string FingerGuessings = nameof(FingerGuessings);
}

public static class FSHPermissions
{
    private static readonly FSHPermission[] _all = new FSHPermission[]
    {
        new ("View Dashboard", FSHAction.View, FSHResource.Dashboard),
        new ("View Hangfire", FSHAction.View, FSHResource.Hangfire),
        new ("View Users", FSHAction.View, FSHResource.Users),
        new ("Search Users", FSHAction.Search, FSHResource.Users),
        new ("Create Users", FSHAction.Create, FSHResource.Users),
        new ("Update Users", FSHAction.Update, FSHResource.Users),
        new ("Delete Users", FSHAction.Delete, FSHResource.Users),
        new ("Export Users", FSHAction.Export, FSHResource.Users),
        new ("View UserRoles", FSHAction.View, FSHResource.UserRoles),
        new ("Update UserRoles", FSHAction.Update, FSHResource.UserRoles),
        new ("View Roles", FSHAction.View, FSHResource.Roles),
        new ("Create Roles", FSHAction.Create, FSHResource.Roles),
        new ("Update Roles", FSHAction.Update, FSHResource.Roles),
        new ("Delete Roles", FSHAction.Delete, FSHResource.Roles),
        new ("View RoleClaims", FSHAction.View, FSHResource.RoleClaims),
        new ("Update RoleClaims", FSHAction.Update, FSHResource.RoleClaims),
        new ("View Tenants", FSHAction.View, FSHResource.Tenants, IsRoot: true),
        new ("Create Tenants", FSHAction.Create, FSHResource.Tenants, IsRoot: true),
        new ("Update Tenants", FSHAction.Update, FSHResource.Tenants, IsRoot: true),
        new ("Upgrade Tenant Subscription", FSHAction.UpgradeSubscription, FSHResource.Tenants, IsRoot: true),

        new ("View Products", FSHAction.View, FSHResource.Products, IsBasic: true),
        new ("Search Products", FSHAction.Search, FSHResource.Products, IsBasic: true),
        new ("Create Products", FSHAction.Create, FSHResource.Products),
        new ("Update Products", FSHAction.Update, FSHResource.Products),
        new ("Delete Products", FSHAction.Delete, FSHResource.Products),
        new ("Export Products", FSHAction.Export, FSHResource.Products),
        new ("View Brands", FSHAction.View, FSHResource.Brands, IsBasic: true),
        new ("Search Brands", FSHAction.Search, FSHResource.Brands, IsBasic: true),
        new ("Create Brands", FSHAction.Create, FSHResource.Brands),
        new ("Update Brands", FSHAction.Update, FSHResource.Brands),
        new ("Delete Brands", FSHAction.Delete, FSHResource.Brands),
        new ("Generate Brands", FSHAction.Generate, FSHResource.Brands),
        new ("Clean Brands", FSHAction.Clean, FSHResource.Brands),

        new ("View Players", FSHAction.View, FSHResource.Players, IsBasic: true),
        new ("Search Players", FSHAction.Search, FSHResource.Players, IsBasic: true),
        new ("Export Players", FSHAction.Export, FSHResource.Players),
        new ("View Bots", FSHAction.View, FSHResource.Bots, IsBasic: true),
        new ("Search Bots", FSHAction.Search, FSHResource.Bots, IsBasic: true),

        new ("View Motor Racings", FSHAction.View, FSHResource.MotorRacings, IsBasic: true),
        new ("Search Motor Racings", FSHAction.Search, FSHResource.MotorRacings, IsBasic: true),
        new ("Export Motor Racings", FSHAction.Export, FSHResource.MotorRacings),
        new ("View Lucky Fruits", FSHAction.View, FSHResource.LuckyFruits, IsBasic: true),
        new ("Search Lucky Fruits", FSHAction.Search, FSHResource.LuckyFruits, IsBasic: true),
        new ("Export Lucky Fruits", FSHAction.Export, FSHResource.LuckyFruits),
        new ("View Lucky Bags", FSHAction.View, FSHResource.LuckyBags, IsBasic: true),
        new ("Search Lucky Bags", FSHAction.Search, FSHResource.LuckyBags, IsBasic: true),
        new ("Export Lucky Bags", FSHAction.Export, FSHResource.LuckyBags),
        new ("View Finger Guessings", FSHAction.View, FSHResource.FingerGuessings, IsBasic: true),
        new ("Search Finger Guessings", FSHAction.Search, FSHResource.FingerGuessings, IsBasic: true),
        new ("Export Finger Guessings", FSHAction.Export, FSHResource.FingerGuessings),
    };

    public static IReadOnlyList<FSHPermission> All { get; } = new ReadOnlyCollection<FSHPermission>(_all);
    public static IReadOnlyList<FSHPermission> Root { get; } = new ReadOnlyCollection<FSHPermission>(_all.Where(p => p.IsRoot).ToArray());
    public static IReadOnlyList<FSHPermission> Admin { get; } = new ReadOnlyCollection<FSHPermission>(_all.Where(p => !p.IsRoot).ToArray());
    public static IReadOnlyList<FSHPermission> Basic { get; } = new ReadOnlyCollection<FSHPermission>(_all.Where(p => p.IsBasic).ToArray());
}

public record FSHPermission(string Description, string Action, string Resource, bool IsBasic = false, bool IsRoot = false)
{
    public string Name => NameFor(Action, Resource);
    public static string NameFor(string action, string resource) => $"Permissions.{resource}.{action}";
}
