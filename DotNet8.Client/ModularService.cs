using DotNet8.Client.Features.Blog.Get;
using DotNet8.Client.Features.Blog.GetById;

namespace DotNet8.Client;

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
        services.AddScoped<BL_BlogById>();
        services.AddScoped<BL_BlogList>();
        return services;
    }

    private static IServiceCollection AddDataAccess(this IServiceCollection services)
    {
        services.AddScoped<DL_BlogCreate>();
        services.AddScoped<DL_BlogUpdate>();
        services.AddScoped<DL_BlogDelete>();
        services.AddScoped<DL_BlogById>();
        services.AddScoped<DL_BlogList>();
        return services;
    }
}