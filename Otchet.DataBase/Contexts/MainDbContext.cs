using Microsoft.EntityFrameworkCore;
using Otchet.Core.Models;

namespace Otchet.DataBase.Contexts;

public class MainDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("Server=localhost;Database=OtchetDB;Uid=root;Pwd=;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EntityTypesConfigurations.CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new EntityTypesConfigurations.ClientConfiguration());
        modelBuilder.ApplyConfiguration(new EntityTypesConfigurations.InvoiceConfiguration());
        modelBuilder.ApplyConfiguration(new EntityTypesConfigurations.FirmConfiguration());
        modelBuilder.ApplyConfiguration(new EntityTypesConfigurations.ProductConfiguration());
        modelBuilder.ApplyConfiguration(new EntityTypesConfigurations.RateConfiguration());
        modelBuilder.ApplyConfiguration(new EntityTypesConfigurations.SaleConfiguration());
        modelBuilder.ApplyConfiguration(new EntityTypesConfigurations.StorageConfiguration());
        modelBuilder.ApplyConfiguration(new EntityTypesConfigurations.UnitConfiguration());
        modelBuilder.ApplyConfiguration(new EntityTypesConfigurations.BankConfiguration());
        modelBuilder.ApplyConfiguration(new EntityTypesConfigurations.CashInConfiguration());
        modelBuilder.ApplyConfiguration(new EntityTypesConfigurations.CashOutConfiguration());
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Firm> Firms { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Rate> Rates { get; set; }
    public DbSet<Storage> Storages { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Bank> Banks { get; set; }
    public DbSet<CashIn> CashIns { get; set; }
    public DbSet<CashOut> CashOuts { get; set; }
    
}