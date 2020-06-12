using ItemManager.Infrastructure.Context;
using Microsoft.Extensions.DependencyInjection;

namespace ItemManager.Crosscutting
{
    public static class NativeInjectorBootstrapper
    {
        public static void RegisterServices (IServiceCollection services)
        {
            services.AddScoped<ManagerContext>();
        }
    }
}
