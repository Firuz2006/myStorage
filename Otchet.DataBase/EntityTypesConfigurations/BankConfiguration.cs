using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Otchet.Core.Models;

namespace Otchet.DataBase.EntityTypesConfigurations;

public class BankConfiguration:IEntityTypeConfiguration<Bank>
{
    public void Configure(EntityTypeBuilder<Bank> builder)
    {
        
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => c.Id).IsUnique();
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(b => b.Name).HasMaxLength(100).IsUnicode(false);
    }
}