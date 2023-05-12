using AccountService.Domain.Entities;

namespace AccountService.Domain.RepositoryInterfaces.Sqlite;

public interface IAccountRepository : IRepository<Account, long>
{
}
