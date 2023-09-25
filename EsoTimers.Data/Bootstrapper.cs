using LVK.Core.DependencyInjection;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EsoTimers.Data;

public class Bootstrapper : IModuleBootstrapper
{
    public void Bootstrap(IModuleBuilder builder)
    {
        builder.Services.AddDbContextFactory<EsoTimersDbContext>(
            options =>
            {
                var connectionString = builder.Configuration["DatabaseConnectionString"];
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("EsoTimers.Data"));
            });
    }
}