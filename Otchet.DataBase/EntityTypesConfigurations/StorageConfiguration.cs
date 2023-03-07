using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Otchet.Core.Models;

namespace Otchet.DataBase.EntityTypesConfigurations;

public class StorageConfiguration:IEntityTypeConfiguration<Storage>
{
    public void Configure(EntityTypeBuilder<Storage> builder)
    {
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => c.Id).IsUnique();
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.Name).HasMaxLength(100).IsRequired(false).IsUnicode(false);
    }
}