using AccountService.Infrastructure.Persistence.Sqlite.Mapping;
using Microsoft.EntityFrameworkCore;

namespace AccountService.Infrastructure.Persistence.Sqlite;

public class AccountDbContext : DbContext
{
    public AccountDbContext(DbContextOptions<AccountDbContext> options)
    : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AccountMapper).Assembly);
    }
}
