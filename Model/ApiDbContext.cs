using Microsoft.EntityFrameworkCore;

namespace firstApi.Model
{
  public class ApiDbContext : DbContext
  {

    public ApiDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Fornecedor> Fornecedores { get; set; }

  }
}