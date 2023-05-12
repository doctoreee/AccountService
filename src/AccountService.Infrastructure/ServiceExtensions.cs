using AccountService.Domain.Configuration;
using AccountService.Domain.RepositoryInterfaces.Sqlite;
using AccountService.Infrastructure.Persistence.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AccountService.Infrastructure;

public static class ServiceExtensions
{
    public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
    {
        var sqliteSetting = configuration.GetSection("ServiceSettings:DatabaseSettings:SqliteSettings").Get<SqliteSettings>();
        var sqliteFilePath = string.Format(sqliteSetting.AccountDbFileName, Directory.GetParent(Environment.CurrentDirectory));
        return services
            .AddDbContext<AccountDbContext>(options => options.UseSqlite(sqliteFilePath))
            .AddScoped<IAccountRepository, AccountRepository>();

    }
}
