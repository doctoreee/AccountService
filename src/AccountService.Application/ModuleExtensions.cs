using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AccountService.Application;

public static class ModuleExtensions
{
    public static void AddApplicationLayer(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}
