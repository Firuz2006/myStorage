using Microsoft.EntityFrameworkCore;
using Otchet.Core.Models;

namespace Otchet.DataBase.Contexts;

public class MainDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("Server=localhost;Database=OtchetDB;Uid=root;Pwd=;");
        // optionsBuilder.LogTo(s=>File.AppendAllText("log.txt",s));
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

    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Client> Clients { get; set; } = null!;
    public DbSet<Firm> Firms { get; set; } = null!;
    public DbSet<Invoice> Invoices { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Rate> Rates { get; set; } = null!;
    public DbSet<Storage> Storages { get; set; } = null!;
    public DbSet<Unit> Units { get; set; } = null!;
    public DbSet<Bank> Banks { get; set; } = null!;
    public DbSet<CashIn> CashIns { get; set; } = null!;
    public DbSet<CashOut> CashOuts { get; set; } = null!;
}