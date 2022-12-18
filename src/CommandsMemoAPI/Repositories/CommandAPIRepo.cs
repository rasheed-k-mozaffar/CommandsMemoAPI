using CommandsMemoAPI.Models;

namespace CommandsMemoAPI.Repositories;

public class CommandAPIRepo : ICommandAPIRepo
{
    public Task CreateCommand(Command cmd)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCommand(Command cmd)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Command>> GetAllCommandsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Command> GetCommandByIdAsync(int id)
    {
        throw new NotImplementedException();
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