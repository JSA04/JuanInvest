using Microsoft.EntityFrameworkCore;
using Api.Domain;

namespace Api;

public class InvestContext : DbContext
{
    public DbSet<Acoes>? Acoes;
}