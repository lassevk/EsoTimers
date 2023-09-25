using LVK.Core.DependencyInjection;

namespace EsoTimers;

public class Bootstrapper : IApplicationBootstrapper<WebApplicationBuilder>
{
    public void Bootstrap(IApplicationBuilder<WebApplicationBuilder> builder)
    {
        builder.Bootstrap(new EsoTimers.Data.Bootstrapper());
    }
}