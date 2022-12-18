using Microsoft.AspNetCore.Mvc;
using CommandsMemoAPI.Repositories;
using CommandsMemoAPI.Models;

namespace CommandsMemoAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommandsController : ControllerBase
{
    //This private read-only field will be assinged the CommandAPIrepo concrete class through the constructor

    /*
    When the constructor gets called , The DI system will get into action and inject the required 
    dependency when we ask for an instance of the ICommandAPIRepo.
    So we assing the injected dependency(CommandAPIRepo in our case) to our private read-only field. 
     */
    private readonly ICommandAPIRepo _commandRepo;

    public CommandsController(ICommandAPIRepo commandRepo)
    {
        _commandRepo = commandRepo;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Command>>> GetAll()
    {
        var commandItems = await _commandRepo.GetAllCommandsAsync();
        return Ok(commandItems);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Command>> GetById(int id)
    {
        var commandItem = await _commandRepo.GetCommandByIdAsync(id);
        if (commandItem is null)
            return NotFound($"No command was found with the ID: {id}");

        return Ok(commandItem);
    }
}
