using CommandsMemoAPI.Repositories;
using CommandsMemoAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace CommandsMemoAPI.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCommandsRepo(this IServiceCollection services) =>
        services.AddScoped<ICommandAPIRepo, CommandAPIRepo>();

    public static void ConfigureSqlConnection(this IServiceCollection services, string ConnectionString) =>
        services.AddDbContext<CommandsContext>(opt => opt.UseSqlServer(ConnectionString));
}