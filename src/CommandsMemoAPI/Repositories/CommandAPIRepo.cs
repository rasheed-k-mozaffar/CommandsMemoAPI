using CommandsMemoAPI.Data;
using CommandsMemoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandsMemoAPI.Repositories;

public class CommandAPIRepo : ICommandAPIRepo
{
    private readonly CommandsContext _context;

    public CommandAPIRepo(CommandsContext context)
    {
        _context = context;
    }

    public Task CreateCommand(Command cmd)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCommand(Command cmd)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Command>> GetAllCommandsAsync()
    {
        return await _context.CommandItems.ToListAsync();
    }

    public async Task<Command> GetCommandByIdAsync(int id)
    {
        return await _context.CommandItems.FindAsync(id);
    }

    public Task<bool> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateCommand(Command cmd)
    {
        throw new NotImplementedException();
    }
}