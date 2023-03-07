using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Otchet.Core.Models;

namespace Otchet.DataBase.EntityTypesConfigurations;

public class CashOutConfiguration:IEntityTypeConfiguration<CashOut>
{
    public void Configure(EntityTypeBuilder<CashOut> builder)
    {
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => c.Id).IsUnique();
        builder.Property(c => c.Id).ValueGeneratedOnAdd();

        builder.Property(c => c.Desk).HasMaxLength(100).IsUnicode(false);
    }
}