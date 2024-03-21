using DotNet8.MicroServiceDemo.Server.Features.Blog.Create;
using DotNet8.MicroServiceDemo.Server.Features.Blog.Delete;
using DotNet8.MicroServiceDemo.Server.Features.Blog.Update;

namespace DotNet8.MicroServiceDemo.Server;

public static class ModularService
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddDataAccess();
        services.AddBusinessLogic();

        return services;
    }

    private static IServiceCollection AddBusinessLogic(this IServiceCollection services)
    {
        services.AddScoped<BL_BlogCreate>();
        services.AddScoped<BL_BlogUpdate>();
        services.AddScoped<BL_BlogDelete>();
        return services;
    }

    private static IServiceCollection AddDataAccess(this IServiceCollection services)
    {
        services.AddScoped<DL_BlogCreate>();
        services.AddScoped<DL_BlogUpdate>();
        services.AddScoped<DL_BlogDelete>();
        return services;
    }
}