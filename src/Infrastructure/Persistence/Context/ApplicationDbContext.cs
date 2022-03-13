using Finbuckle.MultiTenant;
using FSH.WebApi.Application.Common.Events;
using FSH.WebApi.Application.Common.Interfaces;
using FSH.WebApi.Domain.Catalog;
using FSH.WebApi.Domain.FunCenter;
using FSH.WebApi.Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FSH.WebApi.Infrastructure.Persistence.Context;

public class ApplicationDbContext : BaseDbContext
{
    public ApplicationDbContext(ITenantInfo currentTenant, DbContextOptions options, ICurrentUser currentUser, ISerializerService serializer, IOptions<DatabaseSettings> dbSettings, IEventPublisher events)
        : base(currentTenant, options, currentUser, serializer, dbSettings, events)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Brand> Brands => Set<Brand>();

    public DbSet<Player> Players => Set<Player>();
    public DbSet<PlayerInfo> PlayerInfo => Set<PlayerInfo>();
    public DbSet<PlayerBalance> PlayerBalances => Set<PlayerBalance>();
    public DbSet<SignInLog> SignInLogs => Set<SignInLog>();

    public DbSet<Bot> Bots => Set<Bot>();
    public DbSet<BotGame> BotGames => Set<BotGame>();

    public DbSet<Order> Orders => Set<Order>();
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<Timeline> Timelines => Set<Timeline>();
    public DbSet<Reward> Rewards => Set<Reward>();

    public DbSet<MotorRacing> MotorRacings => Set<MotorRacing>();
    public DbSet<MotorRacingTrack> MotorRacingTracks => Set<MotorRacingTrack>();
    public DbSet<MotorRacingBet> MotorRacingBets => Set<MotorRacingBet>();
    public DbSet<MotorRacingReward> MotorRacingRewards => Set<MotorRacingReward>();
    public DbSet<MotorRacingIncome> MotorRacingIncomes => Set<MotorRacingIncome>();

    public DbSet<LuckyFruit> LuckyFruits => Set<LuckyFruit>();
    public DbSet<LuckyFruitTrack> LuckyFruitTracks => Set<LuckyFruitTrack>();
    public DbSet<LuckyFruitBet> LuckyFruitBets => Set<LuckyFruitBet>();
    public DbSet<LuckyFruitReward> LuckyFruitRewards => Set<LuckyFruitReward>();
    public DbSet<LuckyFruitIncome> LuckyFruitIncome => Set<LuckyFruitIncome>();

    public DbSet<LuckyBag> LuckyBags => Set<LuckyBag>();
    public DbSet<LuckyBagRobber> LuckyBagRobbers => Set<LuckyBagRobber>();
    public DbSet<LuckyBagReturn> LuckyBagReturns => Set<LuckyBagReturn>();

    public DbSet<FingerGuessing> FingerGuessings => Set<FingerGuessing>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema(SchemaNames.Catalog);
    }
}