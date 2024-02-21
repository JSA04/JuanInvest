using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _config;

    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Costumer> Costumers { get; set; }

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
        mb.Entity<Costumer>().HasKey(c => c.Id);
        mb.Entity<Costumer>().Property(c => c.Id)
            .HasMaxLength(200);
        mb.Entity<Costumer>().Property(c => c.Name)
            .HasMaxLength(100);    
        mb.Entity<Costumer>().Property(c => c.Surname)
            .HasMaxLength(300);
        mb.Entity<Costumer>().Property(c => c.Cpf)
            .HasMaxLength(11);
        mb.Entity<Costumer>().Property(c => c.Email)
            .HasMaxLength(200);
        mb.Entity<Costumer>().Property(c => c.Password)
            .HasMaxLength(200);
        mb.Entity<Costumer>().Property(c => c.Password)
            .HasMaxLength(20).HasConversion<string>();
    }
}
