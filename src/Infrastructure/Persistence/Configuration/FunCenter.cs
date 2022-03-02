using Finbuckle.MultiTenant.EntityFrameworkCore;
using FSH.WebApi.Domain.WholeGame;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSH.WebApi.Infrastructure.Persistence.Configuration;

public class MotorRacingConfig : IEntityTypeConfiguration<MotorRacing>
{
    public void Configure(EntityTypeBuilder<MotorRacing> builder)
    {
        builder
            .ToTable("MotorRacings", SchemaNames.FunCentr)
            .IsMultiTenant();

        builder
            .Property(b => b.Name)
                .HasMaxLength(256);
    }
}


