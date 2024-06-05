using Microsoft.EntityFrameworkCore;
using Prueba_Desemp.Model;

namespace Prueba_Desemp.Data;

public class BaseContext : DbContext
{
    public BaseContext(DbContextOptions<BaseContext> options) : base(options)
    {
    }
    public DbSet<Vet> Vet { get; set; }
    public DbSet<MyOwner> owners { get; set; }
    public DbSet<MyPet> pets { get; set; }
    public DbSet<MyQuote> quotes { get; set; }
    
}