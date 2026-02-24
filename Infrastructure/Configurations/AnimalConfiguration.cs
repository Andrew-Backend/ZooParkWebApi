using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class AnimalConfiguration : IEntityTypeConfiguration<Zoo>
{
    public void Configure(EntityTypeBuilder<Zoo> builder)
    {
        builder.HasKey(z => z.ZooId);

        builder
            .HasMany(z => z.Animals)
            .WithOne(a => a.Zoo)
            .HasForeignKey(a => a.ZooId);
    }
}