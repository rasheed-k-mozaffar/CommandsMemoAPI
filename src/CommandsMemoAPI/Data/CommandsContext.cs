using Microsoft.EntityFrameworkCore;
using CommandsMemoAPI.Models;

namespace CommandsMemoAPI.Data;

public class CommandsContext : DbContext
{
    public CommandsContext(DbContextOptions<CommandsContext> options) : base(options)
    { }

    public DbSet<Command> CommandItems { get; set; } = null!;
}