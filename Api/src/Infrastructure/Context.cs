using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _config;

    public DbSet<Stock> Stocks { get; set; }
    public DbSet<User> Users { get; set; }

    public AppDbContext(IConfiguration configuration)
    {
        _config = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRES"));

    protected override void OnModelCreating(ModelBuilder mb)
    {
        // Stocks
        mb.Entity<Stock>().HasKey(s => s.Id);
        mb.Entity<Stock>().Property(s => s.Id)
            .HasMaxLength(6);
        mb.Entity<Stock>().Property(s => s.Empresa)
            .HasMaxLength(200).IsRequired();
        mb.Entity<Stock>().Property(s => s.Preco)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.DividendYield)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.PrecoLucro)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.PrecoValorPatrimonial)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.DividaLiquidaEbitda)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.MargemLiquida)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.Roe)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.CagrLucro)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.CagrReceitas)
            .HasPrecision(10, 2);
        mb.Entity<Stock>().Property(s => s.UltimaAtualizacao)
            .HasColumnType("date");

        // Users
        mb.Entity<User>().HasKey(u => u.Email);
        mb.Entity<User>().Property(u => u.UserName)
            .HasMaxLength(200);
        mb.Entity<User>().Property(u => u.Email)
            .HasMaxLength(200);
        mb.Entity<User>().Property(u => u.Password)
            .HasMaxLength(200);
    }
}
