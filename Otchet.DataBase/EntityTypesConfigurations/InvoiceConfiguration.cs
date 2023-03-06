using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Otchet.Core.Models;

namespace Otchet.DataBase.EntityTypesConfigurations;

public class InvoiceConfiguration:IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => c.Id).IsUnique();
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
    }
}