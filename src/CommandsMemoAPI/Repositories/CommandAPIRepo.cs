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

    public async Task CreateCommand(Command cmd)
    {
        if (cmd is null)
            throw new ArgumentNullException(nameof(cmd));

        await _context.CommandItems.AddAsync(cmd);
    }

    public void DeleteCommand(Command cmd)
    {
        if (cmd is null)
            throw new ArgumentNullException(nameof(cmd));

        _context.CommandItems.Remove(cmd);
    }

    public IEnumerable<Command> GetAllCommandsAsync()
    {
        throw new NotImplementedException();
    }

    // public async Task<IEnumerable<Command>> GetAllCommandsAsync()
    // {
    //     return await _context.CommandItems.ToListAsync();
    // }

    public async Task<Command> GetCommandByIdAsync(int id)
    {
        return (await _context.CommandItems.FindAsync(id))!;
    }

    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync() >= 0);
    }

    public Task UpdateCommand(Command cmd)
    {
        //Sorry , But no code will go here ;-)
        return null!;
    }
}