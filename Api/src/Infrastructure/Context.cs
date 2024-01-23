using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _config;

    public DbSet<Stock>? Stocks { get; set; }

    public AppDbContext(IConfiguration configuration)
    {
        _config = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql(_config.GetConnectionString("DefaultConnection"));

    protected override void OnModelCreating(ModelBuilder mb)
    {
        // Stocks
        mb.Entity<Stock>().HasKey(s => s.StockId);
        mb.Entity<Stock>().Property(s => s.StockId)
            .HasMaxLength(6);
        mb.Entity<Stock>().Property(s => s.EnterpriseName)
            .HasMaxLength(200).IsRequired();
        mb.Entity<Stock>().Property(s => s.Price)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.DividendYield)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.Pl)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.Pvp)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.NetDebtEbtida)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.NetMargin)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.Roe)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.CagrProfit)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.CagrIncome)
            .HasPrecision(10, 2);
    }
}
