using CommandsMemoAPI.Repositories;

namespace CommandsMemoAPI.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCommandsRepo(this IServiceCollection services) =>
        services.AddScoped<ICommandAPIRepo, CommandAPIRepo>();
}