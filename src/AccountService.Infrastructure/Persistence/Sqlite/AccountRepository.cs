using AccountService.Domain.Entities;
using AccountService.Domain.RepositoryInterfaces.Sqlite;

namespace AccountService.Infrastructure.Persistence.Sqlite;

public class AccountRepository : SqliteDbContext<Account, long>, IAccountRepository
{
    public AccountRepository(AccountDbContext context) : base(context)
    {
    }
}
