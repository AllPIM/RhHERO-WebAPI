using Finbuckle.MultiTenant.EntityFrameworkCore;
using FSH.WebApi.Domain.FunCenter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSH.WebApi.Infrastructure.Persistence.Configuration;

public class PlayerConfig : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder
            .ToTable("Players", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class PlayerInfoConfig : IEntityTypeConfiguration<PlayerInfo>
{
    public void Configure(EntityTypeBuilder<PlayerInfo> builder)
    {
        builder
            .ToTable("PlayerInfo", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class PlayerBalanceConfig : IEntityTypeConfiguration<PlayerBalance>
{
    public void Configure(EntityTypeBuilder<PlayerBalance> builder)
    {
        builder
            .ToTable("PlayerBalance", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class SignInLogConfig : IEntityTypeConfiguration<SignInLog>
{
    public void Configure(EntityTypeBuilder<SignInLog> builder)
    {
        builder
            .ToTable("SignInLogs", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class BotConfig : IEntityTypeConfiguration<Bot>
{
    public void Configure(EntityTypeBuilder<Bot> builder)
    {
        builder
            .ToTable("Bots", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class BotGameConfig : IEntityTypeConfiguration<BotGame>
{
    public void Configure(EntityTypeBuilder<BotGame> builder)
    {
        builder
            .ToTable("BotGame", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder
            .ToTable("Orders", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class PaymentConfig : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder
            .ToTable("Payments", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class TimelineConfig : IEntityTypeConfiguration<Timeline>
{
    public void Configure(EntityTypeBuilder<Timeline> builder)
    {
        builder
            .ToTable("Timelines", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class RewardConfig : IEntityTypeConfiguration<Reward>
{
    public void Configure(EntityTypeBuilder<Reward> builder)
    {
        builder
            .ToTable("Rewards", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class MotorRacingConfig : IEntityTypeConfiguration<MotorRacing>
{
    public void Configure(EntityTypeBuilder<MotorRacing> builder)
    {
        builder
            .ToTable("MotorRacings", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class MotorRacingTrackConfig : IEntityTypeConfiguration<MotorRacingTrack>
{
    public void Configure(EntityTypeBuilder<MotorRacingTrack> builder)
    {
        builder
            .ToTable("MotorRacingTracks", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class MotorRacingBetConfig : IEntityTypeConfiguration<MotorRacingBet>
{
    public void Configure(EntityTypeBuilder<MotorRacingBet> builder)
    {
        builder
            .ToTable("MotorRacingBets", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class MotorRacingRewardConfig : IEntityTypeConfiguration<MotorRacingReward>
{
    public void Configure(EntityTypeBuilder<MotorRacingReward> builder)
    {
        builder
            .ToTable("MotorRacingRewards", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class MotorRacingIncomeConfig : IEntityTypeConfiguration<MotorRacingIncome>
{
    public void Configure(EntityTypeBuilder<MotorRacingIncome> builder)
    {
        builder
            .ToTable("MotorRacingIncomes", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class LuckyFruitConfig : IEntityTypeConfiguration<LuckyFruit>
{
    public void Configure(EntityTypeBuilder<LuckyFruit> builder)
    {
        builder
            .ToTable("LuckyFruits", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class LuckyFruitTrackConfig : IEntityTypeConfiguration<LuckyFruitTrack>
{
    public void Configure(EntityTypeBuilder<LuckyFruitTrack> builder)
    {
        builder
            .ToTable("LuckyFruitTracks", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class LuckyFruitBetConfig : IEntityTypeConfiguration<LuckyFruitBet>
{
    public void Configure(EntityTypeBuilder<LuckyFruitBet> builder)
    {
        builder
            .ToTable("LuckyFruitBets", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class LuckyFruitRewardConfig : IEntityTypeConfiguration<LuckyFruitReward>
{
    public void Configure(EntityTypeBuilder<LuckyFruitReward> builder)
    {
        builder
            .ToTable("LuckyFruitRewards", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class LuckyFruitIncomeConfig : IEntityTypeConfiguration<LuckyFruitIncome>
{
    public void Configure(EntityTypeBuilder<LuckyFruitIncome> builder)
    {
        builder
            .ToTable("LuckyFruitIncomes", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class LuckyBagConfig : IEntityTypeConfiguration<LuckyBag>
{
    public void Configure(EntityTypeBuilder<LuckyBag> builder)
    {
        builder
            .ToTable("LuckyBags", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class LuckyBagRobberConfig : IEntityTypeConfiguration<LuckyBagRobber>
{
    public void Configure(EntityTypeBuilder<LuckyBagRobber> builder)
    {
        builder
            .ToTable("LuckyBagRobbers", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class LuckyBagReturnConfig : IEntityTypeConfiguration<LuckyBagReturn>
{
    public void Configure(EntityTypeBuilder<LuckyBagReturn> builder)
    {
        builder
            .ToTable("LuckyBagReturns", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}

public class FingerGuessingConfig : IEntityTypeConfiguration<FingerGuessing>
{
    public void Configure(EntityTypeBuilder<FingerGuessing> builder)
    {
        builder
            .ToTable("FingerGuessings", SchemaNames.FunCenter)
            .IsMultiTenant();
    }
}