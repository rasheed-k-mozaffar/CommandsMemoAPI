using CommandsMemoAPI.Models;

namespace CommandsMemoAPI.Repositories;

public interface ICommandAPIRepo
{
    Task<bool> SaveChangesAsync();

    Task<IEnumerable<Command>> GetAllCommandsAsync();
    Task<Command> GetCommandByIdAsync(int id);
    Task CreateCommand(Command cmd);
    void DeleteCommand(Command cmd);
    Task UpdateCommand(Command cmd);



}