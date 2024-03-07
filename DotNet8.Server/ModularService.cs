namespace DotNet8.Server;

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